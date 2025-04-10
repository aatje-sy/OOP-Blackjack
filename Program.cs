using oopBlackjack.Classes;


namespace oopBlackjack
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Deck deck = new Deck();
            Console.ReadLine();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

         
        }
    }
}