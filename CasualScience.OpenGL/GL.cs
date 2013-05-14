using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CasualScience.OpenGL
{
    public static class GL
    {
        private const string Lib = "opengl32.dll";
        [DllImport(Lib)]
        private static extern void glClearColor(float red, float green, float blue, float alpha);
        public static void ClearColor(float red, float green, float blue, float alpha)
        {
            glClearColor(red, green, blue, alpha);
        }
        [DllImport(Lib)]
        private static extern void glViewport (int x, int y, int width, int height);
        public static void ViewPort(int x, int y, int width, int height)
        {
            glViewport(x,y,width,height);
        }
        [DllImport(Lib)]
        private static extern void glClear (int mask);
        public static void Clear(AttribMask mask)
        {
            glClear((int)mask);
        }


        [DllImport(Lib)]
        public extern static UInt32 glCreateShader(ShaderType type);

        [DllImport(Lib)]
        private extern static void glShaderSource(UInt32 shader, Int32 count, String[] data, Int32[] length);
        public static void ShaderSource(UInt32 shader, string source)
        {
            glShaderSource(shader,1,new[]{source},new[]{source.Length});
        }
       
    }
}
