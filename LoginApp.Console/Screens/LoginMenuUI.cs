namespace LoginApp.ConsoleUI.Screens;

public class LoginMenuUI
{
    public static void Show()
    {
        Console.WriteLine("=== Login Menu ===");
        Console.WriteLine("1. Login");
        Console.WriteLine("2. Register");
        Console.WriteLine("3. Exit");
        Console.Write("Select an option: ");
    }
}
