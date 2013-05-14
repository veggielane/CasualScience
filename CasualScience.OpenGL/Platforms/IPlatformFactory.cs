using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CasualScience.OpenGL.Platforms
{
    public interface IPlatformFactory
    {
        IMonitor DefaultMonitor { get; }
        ReadOnlyCollection<IMonitor> Monitors { get; }
        INativeWindow CreateWindow(int width, int height);
    }


    public delegate void ResizedDelegate(int width, int height);
    public delegate void LoadDelegate();
    public delegate void UpdateDelegate();
    public delegate void RenderDelegate();

    public interface INativeWindow
    {
        ResizedDelegate Resized { get; set; }
        LoadDelegate Load { get; set; }
        UpdateDelegate Update { get; set; }
        RenderDelegate Render { get; set; }
        string Title { get; set; }
        void MakeCurrent();
        void SwapBuffers();

        void SetFullscreen(IMonitor monitor);
    }

    public abstract class NativeWindowBase:INativeWindow
    {
        private readonly INativeWindow _implementation;

        protected NativeWindowBase(IPlatformFactory platformFactory, int width, int height)
        {
            _implementation = platformFactory.CreateWindow(width,height);
            _implementation.Resized += OnResize;
            _implementation.Load += OnLoad;
            _implementation.Update += OnUpdate;
            _implementation.Render += OnRender;


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

        public void SetFullscreen(IMonitor monitor)
        {
            _implementation.SetFullscreen(monitor);
        }
    }

    public interface IMonitor
    {
        string Name { get; }
        IMonitorMode CurrentMode { get; }
        IEnumerable<IMonitorMode> Modes { get; }
        bool SetMode(IMonitorMode mode);
    }

    public interface IMonitorMode
    {
        int Width { get; }
        int Height { get; }
        int BitsPerPixel { get; }
        int Frequency { get; }
    }

    public class MonitorMode:IMonitorMode
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int BitsPerPixel { get; private set; }
        public int Frequency { get; private set; }
        public MonitorMode(int width,int height,int bitsPerPixel, int frequency)
        {
            Width = width;
            Height = height;
            BitsPerPixel = bitsPerPixel;
            Frequency = frequency;
        }
        public override string ToString()
        {
            return String.Format("{0}x{1}x{2}x{3}",BitsPerPixel,Width,Height,Frequency);
        }
    }
}
