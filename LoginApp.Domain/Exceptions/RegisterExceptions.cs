namespace LoginApp.Domain.Exceptions;

public class RegisterExceptions
{

    public List<string> RegistrationErrors { get; private set; } = new();

}

public static class UserErrors
{
    public const string MissingField = "El campo es obligatorio.";
}