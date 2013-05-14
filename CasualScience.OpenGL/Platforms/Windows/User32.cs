using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CasualScience.OpenGL.Platforms.Windows
{
    public delegate IntPtr Procedure(IntPtr handle, WindowsMessage message, IntPtr wParam, IntPtr lParam);
    public static class User32
    {

        [DllImport("user32.dll", SetLastError = true), SuppressUnmanagedCodeSecurity]
        public static extern bool ShowWindow(IntPtr hWnd, ShowWindowCommand nCmdShow);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr CreateWindowEx(ExtendedWindowStyle style, IntPtr className, string windowName, WindowStyle Style, int x, int y, int width, int height, IntPtr parent, IntPtr menu, IntPtr instance, IntPtr param);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool DestroyWindow(IntPtr windowHandle);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern ushort RegisterClassEx(ref WindowClassEx windowClass);
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern short UnregisterClass(IntPtr className, IntPtr instance);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr DefWindowProc(IntPtr hWnd, WindowsMessage msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr LoadCursor(IntPtr instance, IntPtr cursorName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetMessage(ref MSG msg, IntPtr windowHandle, int messageFilterMin, int messageFilterMax);
        [DllImport("User32.dll", SetLastError = true)]
        public static extern IntPtr DispatchMessage(ref MSG msg);
        [DllImport("User32.dll", SetLastError = true)]
        public static extern bool TranslateMessage(ref MSG msg);

        public static IntPtr LoadCursor(CursorName cursor)
        {
            return LoadCursor(IntPtr.Zero, new IntPtr((int)cursor));
        }

        [DllImport("user32.dll")]
        public static extern void PostQuitMessage(int exitCode);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowText(IntPtr handle, [Out] StringBuilder titleString, int maxCount);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetWindowText(IntPtr handle, string titleString);

        [DllImport("User32.dll")]
        public static extern long ChangeDisplaySettings(DeviceMode lpDevMode, ChangeDisplaySettingsEnum dwflags);

        [DllImport("User32.dll")]
        public static extern int EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref DeviceMode lpDevMode);

        [DllImport("User32.dll")]
        public static extern int EnumDisplayDevices(string lpDevice, int iDevNum, ref DisplayDevice lpDisplayDevice, int dwFlags);

        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr handle);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int ChangeDisplaySettingsEx(string deviceName, DeviceMode deviceMode, IntPtr handle, ChangeDisplaySettingsEnum dwflags, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool AdjustWindowRectEx(ref Win32Rectangle lpRect, WindowStyle dwStyle, bool bMenu, ExtendedWindowStyle dwExStyle);
        public static Rectangle AdjustWindowRectEx(int width, int height, WindowStyle style, bool menu, ExtendedWindowStyle extendedStyle)
        {
            var rect = new Win32Rectangle
                {
                    Right = width,
                    Bottom = height
                };
            AdjustWindowRectEx(ref rect, style, menu, extendedStyle);
            return rect.ToRectangle();
        }


        [DllImport("User32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PeekMessage(ref MSG msg, IntPtr hWnd, int messageFilterMin, int messageFilterMax, int flags);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetForegroundWindow(IntPtr handle);

        [DllImport("user32.dll")]
        public static extern IntPtr SetFocus(IntPtr handle);
    }
    [Flags]
    public enum ChangeDisplaySettingsEnum
    {
        // ChangeDisplaySettings types (found in winuser.h)
        UpdateRegistry = 0x00000001,
        Test = 0x00000002,
        Fullscreen = 0x00000004,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayDevice
    {
        [MarshalAs(UnmanagedType.U4)]
        public int cb;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceString;
        [MarshalAs(UnmanagedType.U4)]
        public DisplayDeviceStateFlags StateFlags;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceKey;
    }

    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
    public struct DeviceMode
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        [FieldOffset(0)]
        public string DeviceName;
        [FieldOffset(32)]
        public Int16 SpecVersion;
        [FieldOffset(34)]
        public Int16 DriverVersion;
        [FieldOffset(36)]
        public Int16 Size;
        [FieldOffset(38)]
        public Int16 DriverExtra;
        [FieldOffset(40)]
        public DM Fields;
        [FieldOffset(44)]
        public Int16 Orientation;
        [FieldOffset(46)]
        public Int16 PaperSize;
        [FieldOffset(48)]
        public Int16 PaperLength;
        [FieldOffset(50)]
        public Int16 PaperWidth;
        [FieldOffset(52)]
        public Int16 Scale;
        [FieldOffset(54)]
        public Int16 Copies;
        [FieldOffset(56)]
        public Int16 DefaultSource;
        [FieldOffset(58)]
        public Int16 PrintQuality;
        [FieldOffset(44)]
        public WinPoint Position;
        [FieldOffset(52)]
        public Int32 DisplayOrientation;
        [FieldOffset(56)]
        public Int32 DisplayFixedOutput;
        [FieldOffset(60)]
        public short Color;
        [FieldOffset(62)]
        public short Duplex;
        [FieldOffset(64)]
        public short YResolution;
        [FieldOffset(66)]
        public short TTOption;
        [FieldOffset(68)]
        public short Collate;
        [FieldOffset(72)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string FormName;
        [FieldOffset(102)]
        public Int16 LogPixels;
        [FieldOffset(104)]
        public Int32 BitsPerPel;
        [FieldOffset(108)]
        public Int32 PelsWidth;
        [FieldOffset(112)]
        public Int32 PelsHeight;
        [FieldOffset(116)]
        public Int32 DisplayFlags;
        [FieldOffset(116)]
        public Int32 Nup;
        [FieldOffset(120)]
        public Int32 DisplayFrequency;
        public static Int16 SizeInBytes = (Int16)Marshal.SizeOf(default(DeviceMode));
    }

    [Flags]
    public enum DM
    {
        Orientation = 0x1,
        PaperSize = 0x2,
        PaperLength = 0x4,
        PaperWidth = 0x8,
        Scale = 0x10,
        Position = 0x20,
        NUP = 0x40,
        DisplayOrientation = 0x80,
        Copies = 0x100,
        DefaultSource = 0x200,
        PrintQuality = 0x400,
        Color = 0x800,
        Duplex = 0x1000,
        YResolution = 0x2000,
        TTOption = 0x4000,
        Collate = 0x8000,
        FormName = 0x10000,
        LogPixels = 0x20000,
        BitsPerPixel = 0x40000,
        PelsWidth = 0x80000,
        PelsHeight = 0x100000,
        DisplayFlags = 0x200000,
        DisplayFrequency = 0x400000,
        ICMMethod = 0x800000,
        ICMIntent = 0x1000000,
        MediaType = 0x2000000,
        DitherType = 0x4000000,
        PanningWidth = 0x8000000,
        PanningHeight = 0x10000000,
        DisplayFixedOutput = 0x20000000
    }


    [Flags]
    public enum DisplayDeviceStateFlags
    {
        AttachedToDesktop = 0x1,
        MultiDriver = 0x2,
        PrimaryDevice = 0x4,
        MirroringDriver = 0x8,
        VGACompatible = 0x10,
        Removable = 0x20,
        ModesPruned = 0x8000000,
        Remote = 0x4000000,
        Disconnect = 0x2000000
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MSG
    {
        public IntPtr HWnd;
        public WindowsMessage Message;
        public IntPtr WParam;
        public IntPtr LParam;
        public uint Time;
        public WinPoint Point;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WindowClassEx
    {
        public uint Size;
        public WindowClassStyle Style;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public Procedure WndProc;
        public int cbClsExtra;
        public int cbWndExtra;
        public IntPtr Instance;
        public IntPtr Icon;
        public IntPtr Cursor;
        public IntPtr Background;
        public IntPtr MenuName;
        public IntPtr ClassName;
        public IntPtr IconSm;
        public static uint SizeInBytes = (uint)Marshal.SizeOf(default(WindowClassEx));
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WinPoint
    {
        int X;
        int Y;
        internal Point ToPoint()
        {
            return new Point(X, Y);
        }
    }

    public enum ShowWindowCommand
    {
        Hide = 0,
        ShowNormal = 1,
        ShowMinimised = 2,
        ShowMaximised = 3,
        ShowNoActivate = 4,
        Show = 5,
        Minimise = 6,
        ShowMinNoActivate = 7,
        ShowNotActivated = 8,
        Restore = 9,
        ShowDefault = 10,
        ForceMinimise = 11,
    }

    [Flags]
    public enum ExtendedWindowStyle : uint
    {
        AcceptFiles = 0x00000010,
        ApplicationWindow = 0x00040000,
        ClientEdge = 0x00000200,
        Composited = 0x02000000,
        ContextHelp = 0x00000400,
        ControlParent = 0x00010000,
        DialogModalFrame = 0x00000001,
        Layered = 0x00080000,
        LayoutRightToLeft = 0x00400000,
        Left = 0x00000000,
        LeftScrollBar = 0x00004000,
        LeftToRightReading = 0x00000000,
        MDIChild = 0x00000040,
        NoActivate = 0x08000000,
        NoInheritLayout = 0x00100000,
        NoParentNotify = 0x00000004,
        OverlappedWindow = WindowEdge | ClientEdge,
        PaletteWindow = WindowEdge | ToolWindow | Topmost,
        Right = 0x00001000,
        RightScrollBar = 0x00000000,
        RightToLeftReading = 0x00002000,
        StaticEdge = 0x00020000,
        ToolWindow = 0x00000080,
        Topmost = 0x00000008,
        Transparent = 0x00000020,
        WindowEdge = 0x00000100
    }
    [Flags]
    public enum WindowStyle : uint
    {
        Overlapped = 0x00000000,
        Popup = 0x80000000,
        Child = 0x40000000,
        Minimize = 0x20000000,
        Visible = 0x10000000,
        Disabled = 0x08000000,
        ClipSiblings = 0x04000000,
        ClipChildren = 0x02000000,
        Maximize = 0x01000000,
        Caption = 0x00C00000,
        Border = 0x00800000,
        DialogFrame = 0x00400000,
        VScroll = 0x00200000,
        HScreen = 0x00100000,
        SystemMenu = 0x00080000,
        ThickFrame = 0x00040000,
        Group = 0x00020000,
        TabStop = 0x00010000,

        MinimizeBox = 0x00020000,
        MaximizeBox = 0x00010000,

        Tiled = Overlapped,
        Iconic = Minimize,
        SizeBox = ThickFrame,
        TiledWindow = OverlappedWindow,

        OverlappedWindow = Overlapped | Caption | SystemMenu | ThickFrame | MinimizeBox | MaximizeBox,
        PopupWindow = Popup | Border | SystemMenu,
        ChildWindow = Child
    }

    [Flags]
    public enum WindowClassStyle : uint
    {
        ByteAlignClient = 0x1000,
        ByteAlignWindow = 0x2000,
        ClassDC = 0x0040,
        DoubleClicks = 0x0008,
        DropShadow = 0x00020000,
        GlobalClass = 0x4000,
        HRedraw = 0x0002,
        NoClose = 0x0200,
        OwnDC = 0x0020,
        ParentDC = 0x0080,
        SaveBits = 0x0800,
        VRedraw = 0x0001,
        Default = OwnDC
    }

    public enum CursorName
    {
        Arrow = 32512
    }

    public enum WindowsMessage
    {
        Null = 0x0000,
        Create = 0x0001,
        Destroy = 0x0002,
        Move = 0x0003,
        Size = 0x0005,
        Activate = 0x0006,
        SetFocus = 0x0007,
        KillFocus = 0x0008,
        Enable = 0x000A,
        SetRedraw = 0x000B,
        SetText = 0x000C,
        GetText = 0x000D,
        GetTextLength = 0x000E,
        Paint = 0x000F,
        Close = 0x0010,
        QueryEndSession = 0x0011,
        QueryOpen = 0x0013,
        EndSession = 0x0016,
        Quit = 0x0012,
        EraseBackground = 0x0014,
        SystemColorChange = 0x0015,
        ShowWindow = 0x0018,
        WinINIChange = 0x001A,
        SettingChange = WinINIChange,
        DevModeChange = 0x001B,
        ActivateApp = 0x001C,
        FontChange = 0x001D,
        TimeChange = 0x001E,
        CancelMode = 0x001F,
        SetCursor = 0x0020,
        MouseActivate = 0x0021,
        ChildActivate = 0x0022,
        QueueSync = 0x0023,
        GetMinMaxInfo = 0x0024,
        PaintIcon = 0x0026,
        IconEraseBackground = 0x0027,
        NEXTDLGCTL = 0x0028,
        SpoolerStatus = 0x002A,
        DrawItem = 0x002B,
        MeasureItem = 0x002C,
        DeleteItem = 0x002D,
        VKEYTOITEM = 0x002E,
        CharToItem = 0x002F,
        SetFont = 0x0030,
        GetFont = 0x0031,
        SetHotKey = 0x0032,
        GetHotKey = 0x0033,
        QueryDragIcon = 0x0037,
        CompareItem = 0x0039,
        GetObject = 0x003D,
        Compacting = 0x0041,
        COMNotify = 0x0044,
        WindowPositionChanging = 0x0046,
        WindowPositionChanged = 0x0047,
        Power = 0x0048,
        CopyData = 0x004A,
        CnacelJournal = 0x004B,
        Notify = 0x004E,
        INPUTLANGCHANGEREQUEST = 0x0050,
        INPUTLANGCHANGE = 0x0051,
        TCARD = 0x0052,
        HELP = 0x0053,
        USERCHANGED = 0x0054,
        NOTIFYFORMAT = 0x0055,
        CONTEXTMENU = 0x007B,
        STYLECHANGING = 0x007C,
        STYLECHANGED = 0x007D,
        DISPLAYCHANGE = 0x007E,
        GETICON = 0x007F,
        SETICON = 0x0080,
        NCCREATE = 0x0081,
        NCDESTROY = 0x0082,
        NCCALCSIZE = 0x0083,
        NCHITTEST = 0x0084,
        NCPAINT = 0x0085,
        NCACTIVATE = 0x0086,
        GETDLGCODE = 0x0087,
        SYNCPAINT = 0x0088,


        NCMOUSEMOVE = 0x00A0,
        NCLBUTTONDOWN = 0x00A1,
        NCLBUTTONUP = 0x00A2,
        NCLBUTTONDBLCLK = 0x00A3,
        NCRBUTTONDOWN = 0x00A4,
        NCRBUTTONUP = 0x00A5,
        NCRBUTTONDBLCLK = 0x00A6,
        NCMBUTTONDOWN = 0x00A7,
        NCMBUTTONUP = 0x00A8,
        NCMBUTTONDBLCLK = 0x00A9,
        NCXBUTTONDOWN = 0x00AB,
        NCXBUTTONUP = 0x00AC,
        NCXBUTTONDBLCLK = 0x00AD,

        INPUT_DEVICE_CHANGE = 0x00FE,
        INPUT = 0x00FF,

        KEYFIRST = 0x0100,
        KEYDOWN = 0x0100,
        KEYUP = 0x0101,
        CHAR = 0x0102,
        DEADCHAR = 0x0103,
        SYSKEYDOWN = 0x0104,
        SYSKEYUP = 0x0105,
        SYSCHAR = 0x0106,
        SYSDEADCHAR = 0x0107,
        UNICHAR = 0x0109,
        KEYLAST = 0x0109,

        IME_STARTCOMPOSITION = 0x010D,
        IME_ENDCOMPOSITION = 0x010E,
        IME_COMPOSITION = 0x010F,
        IME_KEYLAST = 0x010F,

        INITDIALOG = 0x0110,
        COMMAND = 0x0111,
        SYSCOMMAND = 0x0112,
        TIMER = 0x0113,
        HSCROLL = 0x0114,
        VSCROLL = 0x0115,
        INITMENU = 0x0116,
        INITMENUPOPUP = 0x0117,
        MENUSELECT = 0x011F,
        MENUCHAR = 0x0120,
        ENTERIDLE = 0x0121,
        MENURBUTTONUP = 0x0122,
        MENUDRAG = 0x0123,
        MENUGETOBJECT = 0x0124,
        UNINITMENUPOPUP = 0x0125,
        MENUCOMMAND = 0x0126,

        CHANGEUISTATE = 0x0127,
        UPDATEUISTATE = 0x0128,
        QUERYUISTATE = 0x0129,

        CTLCOLORMSGBOX = 0x0132,
        CTLCOLOREDIT = 0x0133,
        CTLCOLORLISTBOX = 0x0134,
        CTLCOLORBTN = 0x0135,
        CTLCOLORDLG = 0x0136,
        CTLCOLORSCROLLBAR = 0x0137,
        CTLCOLORSTATIC = 0x0138,
        MN_GETHMENU = 0x01E1,

        MOUSEFIRST = 0x0200,
        MOUSEMOVE = 0x0200,
        LBUTTONDOWN = 0x0201,
        LBUTTONUP = 0x0202,
        LBUTTONDBLCLK = 0x0203,
        RBUTTONDOWN = 0x0204,
        RBUTTONUP = 0x0205,
        RBUTTONDBLCLK = 0x0206,
        MBUTTONDOWN = 0x0207,
        MBUTTONUP = 0x0208,
        MBUTTONDBLCLK = 0x0209,
        MOUSEWHEEL = 0x020A,
        XBUTTONDOWN = 0x020B,
        XBUTTONUP = 0x020C,
        XBUTTONDBLCLK = 0x020D,
        MOUSEHWHEEL = 0x020E,

        PARENTNOTIFY = 0x0210,
        ENTERMENULOOP = 0x0211,
        EXITMENULOOP = 0x0212,

        NEXTMENU = 0x0213,
        SIZING = 0x0214,
        CAPTURECHANGED = 0x0215,
        MOVING = 0x0216,

        POWERBROADCAST = 0x0218,

        DEVICECHANGE = 0x0219,

        MDICREATE = 0x0220,
        MDIDESTROY = 0x0221,
        MDIACTIVATE = 0x0222,
        MDIRESTORE = 0x0223,
        MDINEXT = 0x0224,
        MDIMAXIMIZE = 0x0225,
        MDITILE = 0x0226,
        MDICASCADE = 0x0227,
        MDIICONARRANGE = 0x0228,
        MDIGETACTIVE = 0x0229,


        MDISETMENU = 0x0230,
        ENTERSIZEMOVE = 0x0231,
        EXITSIZEMOVE = 0x0232,
        DROPFILES = 0x0233,
        MDIREFRESHMENU = 0x0234,

        IME_SETCONTEXT = 0x0281,
        IME_NOTIFY = 0x0282,
        IME_CONTROL = 0x0283,
        IME_COMPOSITIONFULL = 0x0284,
        IME_SELECT = 0x0285,
        IME_CHAR = 0x0286,
        IME_REQUEST = 0x0288,
        IME_KEYDOWN = 0x0290,
        IME_KEYUP = 0x0291,

        MOUSEHOVER = 0x02A1,
        MOUSELEAVE = 0x02A3,
        NCMOUSEHOVER = 0x02A0,
        NCMOUSELEAVE = 0x02A2,

        WTSSESSION_CHANGE = 0x02B1,

        TABLET_FIRST = 0x02c0,
        TABLET_LAST = 0x02df,

        CUT = 0x0300,
        COPY = 0x0301,
        PASTE = 0x0302,
        CLEAR = 0x0303,
        UNDO = 0x0304,
        RENDERFORMAT = 0x0305,
        RENDERALLFORMATS = 0x0306,
        DESTROYCLIPBOARD = 0x0307,
        DRAWCLIPBOARD = 0x0308,
        PAINTCLIPBOARD = 0x0309,
        VSCROLLCLIPBOARD = 0x030A,
        SIZECLIPBOARD = 0x030B,
        ASKCBFORMATNAME = 0x030C,
        CHANGECBCHAIN = 0x030D,
        HSCROLLCLIPBOARD = 0x030E,
        QUERYNEWPALETTE = 0x030F,
        PALETTEISCHANGING = 0x0310,
        PALETTECHANGED = 0x0311,
        HOTKEY = 0x0312,

        PRINT = 0x0317,
        PRINTCLIENT = 0x0318,

        APPCOMMAND = 0x0319,

        THEMECHANGED = 0x031A,

        CLIPBOARDUPDATE = 0x031D,

        DWMCOMPOSITIONCHANGED = 0x031E,
        DWMNCRENDERINGCHANGED = 0x031F,
        DWMCOLORIZATIONCOLORCHANGED = 0x0320,
        DWMWINDOWMAXIMIZEDCHANGE = 0x0321,

        GETTITLEBARINFOEX = 0x033F,

        HANDHELDFIRST = 0x0358,
        HANDHELDLAST = 0x035F,

        AFXFIRST = 0x0360,
        AFXLAST = 0x037F,

        PENWINFIRST = 0x0380,
        PENWINLAST = 0x038F,

        APP = 0x8000,

        USER = 0x0400,

        REFLECT = USER + 0x1C00,

    }


    [StructLayout(LayoutKind.Sequential)]
    struct WindowPosition
    {
        public IntPtr Handle;
        public IntPtr HandleInsertAfter;
        public int X;
        public int Y;
        public int Width;
        public int Height;
        [MarshalAs(UnmanagedType.U4)]
        public SetWindowPosFlags Flags;
    }

    [Flags]
    public enum SetWindowPosFlags
    {
        NoSize = 0x0001,
        NoMove = 0x0002,
        NoZOrder = 0x0004,
        NoRedraw = 0x0008,
        NoActivate = 0x0010,
        FrameChanged = 0x0020,
        ShowWindow = 0x0040,
        HideWindow = 0x0080,
        NoCopyBits = 0x0100,
        NoOwnerZOrder = 0x0200,
        NoSendChanging = 0x0400,
        DrawFrame = FrameChanged,
        NoReposition = NoOwnerZOrder,
        DeferErase = 0x2000,
        AysncWindowPosition = 0x4000
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PixelFormatDescriptor
    {
        public short Size;
        public short Version;
        public PixelFormatDescriptorFlags Flags;
        public PixelType PixelType;
        public byte ColorBits;
        public byte RedBits;
        public byte RedShift;
        public byte GreenBits;
        public byte GreenShift;
        public byte BlueBits;
        public byte BlueShift;
        public byte AlphaBits;
        public byte AlphaShift;
        public byte AccumBits;
        public byte AccumRedBits;
        public byte AccumGreenBits;
        public byte AccumBlueBits;
        public byte AccumAlphaBits;
        public byte DepthBits;
        public byte StencilBits;
        public byte AuxBuffers;
        public byte LayerType;
        private byte Reserved;
        public int LayerMask;
        public int VisibleMask;
        public int DamageMask;
        public static short SizeInBytes = (short)Marshal.SizeOf(default(PixelFormatDescriptor));
    }
    [Flags]
    public enum PixelFormatDescriptorFlags
    {
        // PixelFormatDescriptor flags
        DoubleBuffer = 0x01,
        Stereo = 0x02,
        DrawToWindow = 0x04,
        DrawToBitmap = 0x08,
        SupportGDI = 0x10,
        SupportOpenGL = 0x20,
        GenericFormat = 0x40,
        NeedPallate = 0x80,
        NeedSystemPallete = 0x100,
        SwapExchange = 0x200,
        SwapCopy = 0x400,
        SwapLayerBuffers = 0x800,
        GenericAccelerated = 0x1000,
        SupportDirectDraw = 0x2000,
        SupportComposition = 0x8000,
        DepthDontCare = unchecked(0x20000000),
        DoubleBufferDontCare = unchecked(0x40000000),
        StereoDontCare = unchecked((int)0x80000000)
    }

    public enum PixelType : byte
    {
        RGBA = 0,
        Indexed = 1
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Win32Rectangle
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;

        public Rectangle ToRectangle()
        {
            return Rectangle.FromLTRB(Left, Top, Right, Bottom);
        }

        static Win32Rectangle From(Rectangle value)
        {
            return new Win32Rectangle
                {
                    Left = value.Left,
                    Top = value.Right,
                    Right = value.Top,
                    Bottom = value.Bottom
                };
        }
    }
}
