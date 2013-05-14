using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasualScience.OpenGL
{
    [Flags]
    public enum AttribMask {DepthBufferBit = 0x00000100, StencilBufferBit = 0x00000400, ColorBufferBit = 0x00004000 }

    public enum ShaderType {FragmentShader = 0x8B30, VertexShader = 0x8B31, GeometryShader = 0x8DD9, TessellationEvaluationShader = 0x8E87, TessellationControlShader = 0x8E88}
}
