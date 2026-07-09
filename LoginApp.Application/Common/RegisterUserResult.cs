namespace LoginApp.Application.Common;

public class RegisterUserResult
{
    // Propiedades para mostrar los datos del usuario registrado. (Password no se muestra)
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    // Constructor privado para inicializar las propiedades de la clase
    private RegisterUserResult(string userName, string password, string email)
    {
        UserName = userName;
        Email = email;
    }
}
