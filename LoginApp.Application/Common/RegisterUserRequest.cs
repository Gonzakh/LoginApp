namespace LoginApp.Application.Common;

public class RegisterUserRequest
{
    // Propiedades para almacenar los datos del usuario a registrar
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    // Constructor privado para inicializar las propiedades de la clase
    public RegisterUserRequest(string userName, string password, string email)
    {   //Debe ser público para que Console pueda crear instancias de RegisterUserRequest y pasar los datos del usuario a registrar.

        UserName = userName;
        Password = password;
        Email = email;
    }
}
