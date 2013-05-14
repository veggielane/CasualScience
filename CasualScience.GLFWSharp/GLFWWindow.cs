using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasualScience.GLFWSharp
{
    public abstract class GLFWWindow
    {
        private readonly int _width;
        private readonly int _height;
        private readonly int _rbits;
        private readonly int _gbits;
        private readonly int _bbits;
        private readonly int _alpha;
        private readonly int _depth;
        private readonly int _stencil;
        private readonly WindowMode _mode;

        private string _title;
        public String Title
        {
            get { return _title; }
            set
            {
                GLFW.SetWindowTitle(value);
                _title = value;
            }
        }

        public static GLFWVersion Version
        {
            get
            {
                var major = 0;
                var minor = 0;
                var rev = 0;
                GLFW.GetVersion(ref major, ref minor, ref rev);
                return new GLFWVersion(major, minor, rev);
            }
        }

        public GLFWWindow(int width, int height, int rbits, int gbits, int bbits, int alpha, int depth, int stencil, WindowMode mode)
        {
            _width = width;
            _height = height;
            _rbits = rbits;
            _gbits = gbits;
            _bbits = bbits;
            _alpha = alpha;
            _depth = depth;
            _stencil = stencil;
            _mode = mode;
        }

        public void Start()
        {
            if (!GLFW.Init()) throw new Exception("Cannot Init GLFW");
            if (!GLFW.OpenWindow(_width, _height, _rbits, _gbits, _bbits, _alpha, _depth, _stencil, _mode)) throw new Exception("Cannot Open GLFW Window");
            Title = String.Format("GLFW: {0}", Version);

            GLFW.SetWindowSizeCallback(Resize);
            Load();

            while (GLFW.GetWindowParam(WindowParam.Opened) == 1)
            {
                Update();
                Render();
                GLFW.SwapBuffers();
            }
        }

        public abstract void Load();
        public abstract void Resize(int width, int height);
        public abstract void Update();
        public abstract void Render();
    }
}
