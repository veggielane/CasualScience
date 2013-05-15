using System.Diagnostics;

namespace CasualScience.OpenGL.Platforms
{
    public abstract class NativeWindowBase:INativeWindow
    {
        private readonly IMonitor _monitor;
        private readonly INativeWindow _implementation;

        protected NativeWindowBase(int width, int height, IMonitor monitor)
        {
            
               
            _monitor = monitor;
            _implementation = Platform.Factory.CreateWindow(width, height, monitor);
            _implementation.Resized += OnResize;
            _implementation.Load += OnLoad;
            _implementation.Update += OnUpdate;
            _implementation.Render += OnRender;
        }


        public void Start()
        {
            _implementation.Start();
        }

        public ResizedDelegate Resized { get; set; }
        public LoadDelegate Load { get; set; }
        public UpdateDelegate Update { get; set; }
        public RenderDelegate Render { get; set; }

        public string Title
        {
            get { return _implementation.Title; } 
            set { _implementation.Title = value; }
        }

        public abstract void OnResize(int width, int height);
        public abstract void OnLoad();
        public abstract void OnUpdate();
        public abstract void OnRender();
        public void MakeCurrent()
        {
            _implementation.MakeCurrent();
        }

        public void SwapBuffers()
        {
            _implementation.SwapBuffers();
        }

        public void SetFullscreen()
        {
            _implementation.SetFullscreen();
        }
    }
}