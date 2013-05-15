using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;

namespace CasualScience.OpenGL.Platforms
{
    public interface IPlatformFactory
    {
        IMonitor DefaultMonitor { get; }
        ReadOnlyCollection<IMonitor> Monitors { get; }
        INativeWindow CreateWindow(int width, int height, IMonitor monitor);
    }


    public delegate void ResizedDelegate(int width, int height);
    public delegate void LoadDelegate();
    public delegate void UpdateDelegate();
    public delegate void RenderDelegate();

    public interface INativeWindow
    {
        void Start();

        ResizedDelegate Resized { get; set; }
        LoadDelegate Load { get; set; }
        UpdateDelegate Update { get; set; }
        RenderDelegate Render { get; set; }
        string Title { get; set; }
        void MakeCurrent();
        void SwapBuffers();
        void SetFullscreen();
    }

    public interface IMonitor
    {
        string Name { get; }
        Point Position { get; set; }
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
