using VNIIA_test.Forms;

namespace VNIIA_test
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MasterForm());
        }
    }
}