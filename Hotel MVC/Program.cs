namespace Hotel_MVC
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

            Model model = new Model();
            Controller controller = new Controller();
            Form1 view = new Form1();

            model.Controller = controller;

            view.Controller = controller;

            controller.Model = model;
            controller.View= view;

            Application.Run(view);
        }
    }
}