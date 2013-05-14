using System;
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

            var factory = new WindowsPlatformFactory();

            var test = new Test(factory);
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

    public class Test:NativeWindowBase
    {
        public Test(IPlatformFactory platformFactory) : base(platformFactory,800,600)
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









    public class TestWin:GLFWWindow
    {
        public TestWin(int width, int height, int rbits, int gbits, int bbits, int alpha, int depth, int stencil, WindowMode mode) : base(width, height, rbits, gbits, bbits, alpha, depth, stencil, mode)
        {
            
        }

        public override void Load()
        {
        
        }

        public override void Resize(int width, int height)
        {

        }

        public override void Update()
        {

        }

        public override void Render()
        {
            GL.Clear(AttribMask.ColorBufferBit | AttribMask.DepthBufferBit);
            GL.ClearColor(1, 0, 0, 0);
        }
    }
}
