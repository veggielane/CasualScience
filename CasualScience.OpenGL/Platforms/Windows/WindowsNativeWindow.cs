using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CasualScience.OpenGL.Platforms.Windows
{
    public class WindowsNativeWindow:INativeWindow
    {
        private readonly string _title;
        private readonly IMonitor _monitor;
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int Bits { get; private set; }

        private IntPtr _handle;
        private readonly IntPtr _instance = Marshal.GetHINSTANCE(typeof(WindowsNativeWindow).Module);

        private readonly IntPtr _className = Marshal.StringToHGlobalAuto(Guid.NewGuid().ToString());
        private IntPtr _hdc;
        private IntPtr _glHandle;

        public WindowsNativeWindow(string title, int width, int height, int bits, IMonitor monitor)
        {
            _title = title;
            _monitor = monitor;
            Width = width;
            Height = height;
            Bits = bits;
        }
        public ResizedDelegate Resized { get; set; }
        public LoadDelegate Load { get; set; }
        public UpdateDelegate Update { get; set; }
        public RenderDelegate Render { get; set; }

        public string Title
        {
            get
            {
                var sb = new StringBuilder();
                User32.GetWindowText(_handle, sb, 100);
                return sb.ToString();
            }
            set { User32.SetWindowText(_handle, value); }
        }

        public void Start()
        {
            new Task(() =>
            {
                RegisterClass();
                CreateWindow();

                _hdc = User32.GetDC(_handle);

                if (_hdc == IntPtr.Zero) throw new Exception("Failed to get Device Context");
                var pfd = new PixelFormatDescriptor
                {
                    Size = PixelFormatDescriptor.SizeInBytes,
                    Version = 1,
                    Flags =
                        PixelFormatDescriptorFlags.DrawToWindow | PixelFormatDescriptorFlags.SupportOpenGL |
                        PixelFormatDescriptorFlags.DoubleBuffer,
                    PixelType = PixelType.RGBA,
                    ColorBits = (byte)Bits,
                    DepthBits = 16,
                };

                var pixelformat = GDI32.ChoosePixelFormat(_hdc, ref pfd);
                if (pixelformat == 0) throw new Exception("Failed to get find pixel format");
                if (!GDI32.SetPixelFormat(_hdc, pixelformat, ref pfd)) throw new Exception("Can't Set The PixelFormat.");

                _glHandle = WGL.CreateContext(_hdc);
                if (_glHandle == IntPtr.Zero) throw new Exception("Failed to create context");

                MakeCurrent();



                User32.ShowWindow(_handle, ShowWindowCommand.Show);
                User32.SetForegroundWindow(_handle);
                User32.SetFocus(_handle);



                if (Resized != null) Resized(Width, Height);
                if (Load != null) Load();
                //User32.ChangeDisplaySettingsEx()

                ProcessEvents();
            }).Start();
           
        }

  
        private void RegisterClass()
        {
            var wc = new WindowClassEx
            {
                Size = WindowClassEx.SizeInBytes,
                Style = WindowClassStyle.HRedraw|WindowClassStyle.VRedraw|WindowClassStyle.OwnDC,
                WndProc = WindowProcedure,
                Instance = _instance,
                ClassName = _className,
                Cursor = User32.LoadCursor(CursorName.Arrow)
            };
            if (User32.RegisterClassEx(ref wc) == 0)
                throw new Exception(String.Format("Failed to reg class. Error: {0}", Marshal.GetLastWin32Error()));
        }

        private WindowStyle _style;
        private ExtendedWindowStyle _extendedStyle;

        private void CreateWindow()
        {
            _style = WindowStyle.ClipSiblings | WindowStyle.ClipChildren;
            _extendedStyle = ExtendedWindowStyle.ApplicationWindow;

            var fullscreen = true;

            int fullWidth, fullHeight;
            if (fullscreen)
            {
                _style |= WindowStyle.Popup;
                fullWidth = Width;
                fullHeight = Height;

            }
            else
            {
                _style |= WindowStyle.Caption | WindowStyle.SystemMenu | WindowStyle.MinimizeBox;

                var rect = User32.AdjustWindowRectEx(Width, Height, _style, false, _extendedStyle);
                fullWidth = rect.Right - rect.Left;
                fullHeight = rect.Bottom - rect.Top;

            }

            _handle = User32.CreateWindowEx(_extendedStyle, _className, _title, _style, _monitor.Position.X, _monitor.Position.Y, fullWidth,
                                                    fullHeight, IntPtr.Zero, IntPtr.Zero, _instance, IntPtr.Zero);
            if (_handle == IntPtr.Zero)
                throw new Exception(String.Format("Failed to create window. Error: {0}",
                                                  Marshal.GetLastWin32Error()));

        }





        private bool _done;
        public void ProcessEvents()
        {
            var msg = new MSG();
            while (!_done)									// Loop That Runs While done=FALSE
            {
                if (User32.PeekMessage(ref msg, _handle, 0, 0, 0x0001))	// Is There A Message Waiting?
                {
                    if (msg.Message == WindowsMessage.Quit)				// Have We Received A Quit Message?
                    {
                        _done = true;							// If So done=TRUE
                    }
                    else									// If Not, Deal With Window Messages
                    {
                        User32.TranslateMessage(ref msg);
                        User32.DispatchMessage(ref msg);
                    }
                }
                else										// If There Are No Messages
                {
                    if (Update != null) Update();
                    if (Render != null) Render();
                    SwapBuffers();
                }
            }
        }

        public void MakeCurrent()
        {
            WGL.MakeCurrent(_hdc, _glHandle);
        }

        public void SwapBuffers()
        {
            WGL.SwapBuffers(_hdc);
        }

        public void SetFullscreen()
        {

            var exStyle = ExtendedWindowStyle.ApplicationWindow;
            var style = WindowStyle.Popup;

            var dm = new DeviceMode
            {
                Size = DeviceMode.SizeInBytes,
                Position = WinPoint.FromPoint(_monitor.Position),
                PelsWidth = Width,
                PelsHeight = Height,
                BitsPerPel = Bits,
                Fields = DM.PelsHeight | DM.PelsWidth | DM.BitsPerPixel
            };
            User32.ChangeDisplaySettingsEx(_monitor.Name, dm, IntPtr.Zero, ChangeDisplaySettingsEnum.Fullscreen, IntPtr.Zero);
            User32.ShowWindow(_handle, ShowWindowCommand.Show);
            User32.SetForegroundWindow(_handle);
            User32.SetFocus(_handle);
           // User32.ChangeDisplaySettings(dm, ChangeDisplaySettingsEnum.Fullscreen);
            //var rect = new Win32Rectangle { Left = 0, Right = Width, Top = 0, Bottom = Bits };
            //User32.AdjustWindowRectEx(ref rect, style, false, exStyle);
        }

        void DestroyWindow()
        {
            User32.DestroyWindow(_handle);
        } 

        IntPtr WindowProcedure(IntPtr handle, WindowsMessage message, IntPtr wParam, IntPtr lParam)
        {
            switch (message)
            {
                case WindowsMessage.Destroy:
                    User32.UnregisterClass(_className, _instance);
                    break;
                case WindowsMessage.Close:
                    var e = new CancelEventArgs();
                    if (!e.Cancel)
                    { 
                        DestroyWindow();
                        break;
                    }
                    return IntPtr.Zero;
                case WindowsMessage.WindowPositionChanged:
                    var pos = (WindowPosition)Marshal.PtrToStructure(lParam, typeof(WindowPosition));
                    if (!pos.Flags.HasFlag(SetWindowPosFlags.NoSize) && Resized != null) Resized(pos.Width, pos.Height);
                    break;
                default:
                    return User32.DefWindowProc(handle, message, wParam, lParam);
            }
            return IntPtr.Zero;
        }
    }
}