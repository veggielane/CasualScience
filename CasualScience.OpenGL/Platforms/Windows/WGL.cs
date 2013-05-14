using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CasualScience.OpenGL.Platforms.Windows
{
    public static class WGL
    {
        const string Library = "OPENGL32.DLL";
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Library, SetLastError = true)]
        private extern static IntPtr wglCreateContext(IntPtr hDc);
        public static IntPtr CreateContext(IntPtr handle)
        {
            return wglCreateContext(handle);
        }

        [SuppressUnmanagedCodeSecurity()]
        [DllImport(Library, SetLastError = true)]
        private extern static bool wglMakeCurrent(IntPtr hDc, IntPtr newContext);
        public static bool MakeCurrent(IntPtr handle, IntPtr newContext)
        {
            return wglMakeCurrent(handle, newContext);
        }

        [SuppressUnmanagedCodeSecurity()]
        [DllImport(Library, SetLastError = true)]
        private extern static bool wglSwapBuffers(IntPtr hdc);
        public static bool SwapBuffers(IntPtr handle)
        {
            return wglSwapBuffers(handle);
        }
    }
}
