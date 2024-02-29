namespace Proyecto
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Ingresas_DVDs());
            //Application.Run(new Form1());

            using (Form1 mainForm = new Form1())
            {
                mainForm.ShowDialog();
            }
        }
    }
}