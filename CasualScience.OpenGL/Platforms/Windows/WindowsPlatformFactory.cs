using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;

namespace CasualScience.OpenGL.Platforms.Windows
{
    public class WindowsPlatformFactory:IPlatformFactory
    {
        
        public IMonitor DefaultMonitor { get; private set; }
        private readonly IList<IMonitor> _monitors;
        public ReadOnlyCollection<IMonitor> Monitors
        {
            get { return new ReadOnlyCollection<IMonitor>(_monitors); }
        }

        public INativeWindow CreateWindow(int width, int height, IMonitor monitor)
        {
            return new WindowsNativeWindow("testing", width, height, 16, monitor);
        }

        public WindowsPlatformFactory()
        {
            _monitors = new List<IMonitor>();
            var device = new DisplayDevice {cb = Marshal.SizeOf(typeof (DisplayDevice))};
            var num = 0;
            while (User32.EnumDisplayDevices(null, num++, ref device, 0) != 0)
            {
                if(device.StateFlags.HasFlag(DisplayDeviceStateFlags.AttachedToDesktop))
                {
                    var monitor = new WindowsMonitor(device);
                    _monitors.Add(monitor);
                    if(device.StateFlags.HasFlag(DisplayDeviceStateFlags.PrimaryDevice))
                    {
                        DefaultMonitor = monitor;
                    }
                }
            }
        }
    }
}

