using System;
using System.Collections.Generic;
using System.Drawing;

namespace CasualScience.OpenGL.Platforms.Windows
{
    public class WindowsMonitor:IMonitor
    {
        private IList<IMonitorMode> _modes;
        public string Name { get; private set; }


        public Point Position
        {
            get
            {
                var devmode = new DeviceMode
                    {
                        Size = DeviceMode.SizeInBytes
                    };
                User32.EnumDisplaySettingsEx(Name, -1, ref devmode, 0x00000004);
                return devmode.Position.ToPoint();
            } set
            {
                throw new NotImplementedException();
            }
        }


        public IMonitorMode CurrentMode { get; private set; }
        public IEnumerable<IMonitorMode> Modes
        {
            get { return _modes; }
        }

        public WindowsMonitor(DisplayDevice device)
        {
            Name = device.DeviceName;
            _modes = new List<IMonitorMode>();
            var mode = new DeviceMode();
            var num = -1;
            while (User32.EnumDisplaySettings(device.DeviceName, num++, ref mode) !=0)
            {
                _modes.Add(new MonitorMode( mode.PelsWidth, mode.PelsHeight,mode.BitsPerPel,mode.DisplayFrequency));
            }
        }

        public bool SetMode(IMonitorMode mode)
        {
            throw new NotImplementedException();
            var dm = new DeviceMode()
                {
                    PelsWidth = mode.Width,
                    PelsHeight = mode.Height,
                    BitsPerPel = mode.BitsPerPixel,
                    DisplayFrequency = mode.Frequency,
                    Fields = DM.PelsWidth | DM.PelsHeight | DM.BitsPerPixel | DM.DisplayFrequency
                };
            return User32.ChangeDisplaySettingsEx(Name, dm, IntPtr.Zero, ChangeDisplaySettingsEnum.Fullscreen, IntPtr.Zero) == 0;
        }
    }
}