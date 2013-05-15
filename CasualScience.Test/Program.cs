using System;
using System.Diagnostics;
using System.Threading.Tasks;
using CasualScience.GLFWSharp;
using CasualScience.OpenGL;
using CasualScience.OpenGL.Platforms;
using CasualScience.OpenGL.Platforms.Windows;

namespace CasualScience.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new TestWindow(Platform.Factory.DefaultMonitor);
            a.Start();
            a.SetFullscreen();

            var b = new TestWindow(Platform.Factory.Monitors[1]);
            b.Start();
            b.SetFullscreen();

            //var test2 = new Test(factory);

            //test.SetFullscreen(factory.Monitors[0]);
            //test2.SetFullscreen(factory.Monitors[1]);

            

            //var win = test.CreateWindow();
            //win.Resized += (width, height) => Console.WriteLine("resized");
            ////win.Show();
            //Console.WriteLine(win.Title);
            //win.Title = "hello";
            ////Console.WriteLine(test.DefaultMonitor.SetMode(new MonitorMode(720, 480, 16, 60)));
        
            
            ////var t = new Window();
            ////var win = new TestWin(800, 600, 8, 8, 8, 0, 24, 0, WindowMode.Window);
            ////win.Start();

            //var win2 = test.CreateWindow();
            //win2.Show();

           // win.ProcessEvents();
            Console.ReadLine();
        }
    }

    public class TestWindow:NativeWindowBase
    {
        public TestWindow(IMonitor monitor)
            : base(800, 600,monitor)
        {

        }

        public override void OnResize(int width, int height)
        {
            //GL.ViewPort(0,0,width,height);
        }

        public override void OnLoad()
        {


    //        var vs = GL.glCreateShader(ShaderType.VertexShader);
    //        var source =
    //"#version 120           \n" +
    //"void main(void) {        "+
    //"  gl_FragColor[0] = 0.0; "+
    //"  gl_FragColor[1] = 0.0; "+
    //"  gl_FragColor[2] = 1.0; "+
    //"}";
    //        GL.ShaderSource(vs,source);


        }

        public override void OnUpdate()
        {

        }

        public override void OnRender()
        {
            GL.Clear(AttribMask.ColorBufferBit | AttribMask.DepthBufferBit);
            GL.ClearColor(0.5f, 0.5f, 0.5f, 0.5f);
            
        }
    }
}
