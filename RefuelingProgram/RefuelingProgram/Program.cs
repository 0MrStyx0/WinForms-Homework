using RefuelingProgram.Model;
using RefuelingProgram.Presenter;

namespace RefuelingProgram
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

            PricePresenter presenter = new PricePresenter();
            BestOil bestOil = new BestOil(presenter);

            Application.Run(bestOil);
        }
    }
}