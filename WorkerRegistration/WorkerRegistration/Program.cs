using WorkerRegistration.Presenter;

namespace WorkerRegistration
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
            WorkerPresenter workerPresenter = new WorkerPresenter();
            WorkerView workerView = new WorkerView(workerPresenter);
            Application.Run(workerView);
        }
    }
}