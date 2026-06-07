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

    public static void LoginMenu()
    {
        Console.WriteLine("=== Login Menu ===");
        Console.WriteLine("Enter your email");
        Console.WriteLine($"Your Email is {Console.ReadLine()}");
        Console.WriteLine("Enter your password");
        Console.WriteLine($"Your Password is {Console.ReadLine()}");
    }
}
