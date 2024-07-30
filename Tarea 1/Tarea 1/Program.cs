using System.Security.Cryptography.X509Certificates;

namespace Tarea_1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main(string[] args)
        {
            int puertoEscucha = int.Parse(args[2]);
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new CHAT(puertoEscucha));
        }
    }
}