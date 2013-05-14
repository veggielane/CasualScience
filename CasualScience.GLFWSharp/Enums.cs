namespace CasualScience.GLFWSharp
{
    public enum WindowMode { Window = 0x00010001, FullScreen = 0x00010002 }
    public enum WindowHint
    {
        RefreshRate = 0x0002000B, 
        AccumulationRedBits = 0x0002000C, 
        AccumulationGreenBits = 0x0002000D, 
        AccumulationBlueBits = 0x0002000E,
        AccumulationAlphaBits = 0x0002000F,
        AuxiliaryBuffers = 0x00020010,
        Stereo = 0x00020011,
        WindowNoResize = 0x00020012,
        FSAASamples = 0x00020013,
        OpenGLVersionMajor = 0x00020014,
        OpenGLVersionMinor = 0x00020015,
        OpenGLForwardCompatible = 0x00020016,
        OpenGLDebugContext = 0x00020017,
        OpenGLProfile = 0x00020018
    }
    public enum WindowParam
    {
        Opened = 0x00020001,
        Active = 0x00020002,
        Iconified = 0x00020003,
        Accelerated = 0x00020004,
        RedBits = 0x00020005,
        GreenBits = 0x00020006,
        BlueBits = 0x00020007,
        AlphaBits = 0x00020008,
        DepthBits = 0x00020009,
        StencilBits = 0x0002000A,
        RefreshRate = 0x0002000B,
        AccumulationRedBits = 0x0002000C,
        AccumulationGreenBits = 0x0002000D,
        AccumulationBlueBits = 0x0002000E,
        AccumulationAlphaBits = 0x0002000F,
        AuxiliaryBuffers = 0x00020010,
        Stereo = 0x00020011,
        WindowNoResize = 0x00020012,
        FSAASamples = 0x00020013,
        OpenGLVersionMajor = 0x00020014,
        OpenGLVersionMinor = 0x00020015,
        OpenGLForwardCompatible = 0x00020016,
        OpenGLDebugContext = 0x00020017,
        OpenGLProfile = 0x00020018
    }
    public enum OpenGLProfile
    {
        Core = 0x00050001,
        Compat = 0x00050002
    }


    public enum MouseButton
    {
           Button1 = 0,
           Button2 = 1,
           Button3 = 2,
           Button4 = 3,
           Button5 = 4,
           Button6 = 5,
           Button7 = 6,
           Button8 = 7
    }
}
