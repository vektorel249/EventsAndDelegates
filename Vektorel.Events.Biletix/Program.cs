namespace Vektorel.Events.Biletix
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmWelcome());
        }
    }
}