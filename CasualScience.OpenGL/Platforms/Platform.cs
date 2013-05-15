using CasualScience.OpenGL.Platforms.Windows;

namespace CasualScience.OpenGL.Platforms
{
    public static class Platform
    {
        public static IPlatformFactory Factory { get; private set; }
        static Platform()
        {
            Factory = new WindowsPlatformFactory();
        }
    }
}