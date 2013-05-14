using System;

namespace CasualScience.GLFWSharp
{
    public struct GLFWVersion
    {
        public int Major;
        public int Minor;
        public int Revision;

        public GLFWVersion(int major, int minor, int revision)
        {
            Major = major;
            Minor = minor;
            Revision = revision;
        }

        public override string ToString()
        {
            return String.Format("{0}.{1}.{2}", Major, Minor, Revision);
        }
    }

    public struct GLFWWindowSize
    {
        public int Width;
        public int Height;
    }

    public struct GLFWVideoMode
    {
        public int Width, Height, RedBits, GreenBits, BlueBits;
        public override string ToString()
        {
            return String.Format("{0},{1},{2},{3},{4}", Width, Height, RedBits, GreenBits, BlueBits);
        }
    }
}
