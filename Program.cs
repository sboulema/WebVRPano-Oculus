using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace WebVRPano_Oculus
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                var tinyId = args[0].Split('/').Last();
                var appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

                Environment.SetEnvironmentVariable("GOOGLE_API_KEY", "no", EnvironmentVariableTarget.User);
                Environment.SetEnvironmentVariable("GOOGLE_DEFAULT_CLIENT_ID", "no", EnvironmentVariableTarget.User);
                Environment.SetEnvironmentVariable("GOOGLE_DEFAULT_CLIENT_SECRET", "no", EnvironmentVariableTarget.User);

                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Path.Combine(appDir, "chrome.exe");
                startInfo.Arguments = $"--enable-webvr http://sboulema.nl:8080/{tinyId}";
                Process.Start(startInfo);
            }
        }
    }
}
