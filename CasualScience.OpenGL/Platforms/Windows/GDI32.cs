using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CasualScience.OpenGL.Platforms.Windows
{
    public static class GDI32
    {
        [DllImport("gdi32.dll")]
        public static extern int ChoosePixelFormat(IntPtr dc, ref PixelFormatDescriptor pfd);

        [DllImport("gdi32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetPixelFormat(IntPtr dc, int format, ref PixelFormatDescriptor pfd);



    }
}
