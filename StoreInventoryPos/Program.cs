namespace StoreInventoryPos
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
            Application.Run(new LoginPage());
            //Application.Run(new CreateUser());
            // Application.Run(new modifyUser());
            //Application.Run(new selectionCart());


            /////  Dashboard
            //Application.Run(new adminDashboard());

            //Application.Run(new managerDashboard());

            //Application.Run(new staffDashboard());







        }
    }
}