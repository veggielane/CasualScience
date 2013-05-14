using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;

namespace CasualScience.GLFWSharp
{
    public static class GLFW
    {
        private const string Lib = "Lib/GLFW.dll";


        [DllImport(Lib)]
        private static extern int glfwInit();
        public static bool Init()
        {
            return glfwInit() == 1;
        }

        [DllImport(Lib)]
        private static extern void glfwTerminate();
        public static void Terminate()
        {
            glfwTerminate();   
        }

        [DllImport(Lib)]
        private static extern void glfwGetVersion(ref int major, ref int minor, ref int rev);
        public static void GetVersion(ref int major, ref int minor, ref int rev)
        {
            glfwGetVersion(ref major, ref minor, ref rev);
        }

        [DllImport(Lib)]
        private static extern int glfwOpenWindow(int width, int height, int redbits, int greenbits, int bluebits, int alphabits, int depthbits, int stencilbits, int mode);
        public static bool OpenWindow(int width, int height, int rbits, int gbits, int bbits, int alpha, int depth, int stencil, WindowMode mode)
        {
            return glfwOpenWindow(width, height, rbits, gbits, bbits, alpha, depth, stencil, (int)mode) == 1;
        }

        [DllImport(Lib)]
        private static extern void glfwOpenWindowHint(int target, int hint);
        public static void OpenWindowHint(WindowHint target, int hint)
        {
            glfwOpenWindowHint((int)target, hint);
        }
        public static void OpenWindowHint(WindowHint target, OpenGLProfile profile)
        {
            glfwOpenWindowHint((int)target, (int)profile);
        }

        [DllImport(Lib)]
        private static extern void glfwCloseWindow();
        public static void CloseWindow()
        {
            glfwCloseWindow();
        }

        [DllImport(Lib)]
        private static extern void glfwSetWindowTitle(string title);
        public static void SetWindowTitle(string title)
        {
            glfwSetWindowTitle(title);
        }
        
        [DllImport(Lib)]
        private static extern void glfwGetWindowSize(ref int width, ref int height);
        public static void GetWindowSize(ref int width, ref int height)
        {
            glfwGetWindowSize(ref width, ref height);
        }

        [DllImport(Lib)]
        private static extern void glfwSetWindowSize(int width, int height);
        public static void SetWindowSize(int width, int height)
        {
            glfwSetWindowSize(width, height);
        }

        //public static GLFWWindowSize WindowSize
        //{
        //    get
        //    {
        //        int width = 0;
        //        int height = 0;
        //        glfwGetWindowSize(ref width, ref height);
        //        return new GLFWWindowSize {Width = width, Height = height};
        //    }
        //    set
        //    {
        //        glfwSetWindowSize(value.Width,value.Height);
        //    }
        //}

        [DllImport(Lib)]
        private static extern void glfwSetWindowPos(int x, int y);
        public static void SetWindowPos(int x, int y)
        {
            glfwSetWindowPos(x, y);
        }

        //public static Point WindowPosition
        //{
        //    set
        //    {
        //        glfwSetWindowPos(value.X, value.Y);
        //    }
        //}

        [DllImport(Lib)]
        private static extern void glfwIconifyWindow();
        public static void IconifyWindow()
        {
            glfwIconifyWindow();
        }
        
        [DllImport(Lib)]
        private static extern void glfwRestoreWindow();
        public static void RestoreWindow()
        {
            glfwRestoreWindow();
        }
        
        [DllImport(Lib)]
        private static extern void glfwSwapBuffers();
        public static void SwapBuffers()
        {
            glfwSwapBuffers();
        }

        [DllImport(Lib)]
        private static extern void glfwSwapInterval(int interval);
        public static void SwapInterval(int interval)
        {
            glfwSwapInterval(interval);
        }

        [DllImport(Lib)]
        private static extern int glfwGetWindowParam(int param);
        public static int GetWindowParam(WindowParam param)
        {
            return glfwGetWindowParam((int) param);
        }

        public delegate void GLFWWindowSizeFunc(int width, int height);

        [DllImport(Lib)]
        private static extern void glfwSetWindowSizeCallback(GLFWWindowSizeFunc callback);

        public static void SetWindowSizeCallback(GLFWWindowSizeFunc callback)
        {
            glfwSetWindowSizeCallback(callback);
        }

        [DllImport(Lib)]
        private static extern void glfwSetWindowCloseCallback(GLFWWindowSizeFunc callback);
        public static void SetWindowCloseCallback(GLFWWindowSizeFunc callback)
        {
            glfwSetWindowCloseCallback(callback);
        }


        public delegate void GLFWWindowRefreshFunc();
        [DllImport(Lib)]
        private static extern void glfwSetWindowRefreshCallback(GLFWWindowRefreshFunc callback);
        public static void SetWindowRefreshCallback(GLFWWindowRefreshFunc callback)
        {
            glfwSetWindowRefreshCallback(callback);
        }


        /* Video mode functions */
        [DllImport(Lib)]
        private static extern int glfwGetVideoModes([In, Out] GLFWVideoMode[] list, int maxcount);
        public static IEnumerable<GLFWVideoMode> GetVideoModes(int maxcount)
        {
            var temp = new GLFWVideoMode[maxcount];
            var num = glfwGetVideoModes(temp, maxcount);
            for (var i = 0; i < num; i++)
            {
                yield return temp[i];
            }
        }

        [DllImport(Lib)]
        private static extern void glfwGetDesktopMode(ref GLFWVideoMode mode);
        public static GLFWVideoMode GetDesktopMode()
        {
            var mode = new GLFWVideoMode();
            glfwGetDesktopMode(ref mode);
            return mode;
        }


        /* Input handling */
        [DllImport(Lib)]
        private static extern void glfwPollEvents();
        public static void PollEvents()
        {
            glfwPollEvents();
        }

        [DllImport(Lib)]
        private static extern void glfwWaitEvents();
        public static void WaitEvents()
        {
            glfwWaitEvents();
        }
        [DllImport(Lib)]
        private static extern int glfwGetKey(int key);
        public static bool GetKey(int key)
        {
            return glfwGetKey(key) == 1;
        }

        [DllImport(Lib)]
        private static extern int glfwGetMouseButton(int button);
        public static bool GetMouseButton(MouseButton button)
        {
            return glfwGetMouseButton((int) button) == 1;
        }

        [DllImport(Lib)]
        private static extern void glfwGetMousePos(ref int xpos, ref int ypos);
        public static Point GetMousePosition()
        {
            var x = 0;
            var y = 0;
            glfwGetMousePos(ref x,ref y);
            return new Point(x,y);
        }

        [DllImport(Lib)]
        private static extern void glfwSetMousePos(int xpos, int ypos);
        public static void SetMousePosition(Point pos)
        {
            glfwSetMousePos(pos.X,pos.Y);
        } 

        [DllImport(Lib)]
        private static extern int glfwGetMouseWheel();
        public static int GetMouseWheel()
        {
            return glfwGetMouseWheel();
        }

        [DllImport(Lib)]
        private static extern void glfwSetMouseWheel(int pos);
        //private static extern void glfwSetKeyCallback( GLFWkeyfun cbfun );
        //private static extern void glfwSetCharCallback( GLFWcharfun cbfun );
        //private static extern void glfwSetMouseButtonCallback( GLFWmousebuttonfun cbfun );
        //private static extern void glfwSetMousePosCallback( GLFWmouseposfun cbfun );
        //private static extern void glfwSetMouseWheelCallback( GLFWmousewheelfun cbfun );

        /* Joystick input */

        [DllImport(Lib)]
        private static extern int glfwGetJoystickParam(int joy, int param);

        [DllImport(Lib)]
        private static extern int glfwGetJoystickPos(int joy, ref float pos, int numaxes);

        //[DllImport(Lib)]
        //private static extern int glfwGetJoystickButtons( int joy, unsigned char *buttons, int numbuttons );

        /* Time */

        [DllImport(Lib)]
        private static extern double glfwGetTime();

        [DllImport(Lib)]
        private static extern void glfwSetTime(double time);

        [DllImport(Lib)]
        private static extern void glfwSleep(double time);

        /* Extension support */

        [DllImport(Lib)]
        private static extern int glfwExtensionSupported(string extension);

        //[DllImport(Lib)]
        //private static extern void* glfwGetProcAddress( const char *procname );
        [DllImport(Lib)]
        private static extern void glfwGetGLVersion(ref int major, ref int minor, ref int rev);

        /* Threading support */
        //private static extern GLFWthread glfwCreateThread( GLFWthreadfun fun, void *arg );
        //private static extern void glfwDestroyThread( GLFWthread ID );
        //private static extern int  glfwWaitThread( GLFWthread ID, int waitmode );
        //private static extern GLFWthread glfwGetThreadID;
        //private static extern GLFWmutex glfwCreateMutex;
        //private static extern void glfwDestroyMutex( GLFWmutex mutex );
        //private static extern void glfwLockMutex( GLFWmutex mutex );
        //private static extern void glfwUnlockMutex( GLFWmutex mutex );
        //private static extern GLFWcond glfwCreateCond;
        //private static extern void glfwDestroyCond( GLFWcond cond );
        //private static extern void glfwWaitCond( GLFWcond cond, GLFWmutex mutex, double timeout );
        //private static extern void glfwSignalCond( GLFWcond cond );
        //private static extern void glfwBroadcastCond( GLFWcond cond );
        //private static extern int  glfwGetNumberOfProcessors;

        /* Enable/disable functions */
        //private static extern void glfwEnable( int token );
        //private static extern void glfwDisable( int token );

        /* Image/texture I/O support */
        //private static extern int  glfwReadImage( const char *name, GLFWimage *img, int flags );
        //private static extern int  glfwReadMemoryImage( const void *data, long size, GLFWimage *img, int flags );
        //private static extern void glfwFreeImage( GLFWimage *img );
        //private static extern int  glfwLoadTexture2D( const char *name, int flags );
        //private static extern int  glfwLoadMemoryTexture2D( const void *data, long size, int flags );
        //private static extern int  glfwLoadTextureImage2D( GLFWimage *img, int flags );


    }
}