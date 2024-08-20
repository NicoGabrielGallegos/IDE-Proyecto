namespace ClienteWinForms
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

            FormLogin login = new FormLogin();
            login.FormClosed += new FormClosedEventHandler(FormClosed);
            login.Show();

            Application.Run();
        }

        /*
        private static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0) Application.Exit();
            else Application.OpenForms[0].FormClosed += FormClosed;
        }*/
        private static void FormClosed(object? sender, FormClosedEventArgs e)
        {
            Form? f = sender as Form;
            if (f != null)
            {
                f.FormClosed -= FormClosed;
            }
            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Form? form = Application.OpenForms[0] as Form;
                if (form != null)
                {
                    form.FormClosed += FormClosed;
                }
            }
        }
    }
}