

using LoginApp.ConsoleUI.Screens;

namespace LoginApp.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var loginMenu = new Screens.LoginMenuUI();
            LoginMenuUI.Show();

        }
    }
}
