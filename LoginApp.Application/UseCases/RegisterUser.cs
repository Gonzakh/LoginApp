using LoginApp.Application.Interfaces;
using LoginApp.Domain.ValueObjects;

namespace LoginApp.Application.UseCases;

public class RegisterUser
{
    /// Proposito: Gestionar el proceso de registro de un nuevo usuario, 
    /// incluyendo la validación de correo electrónico y contraseña, y el hashing de la contraseña 
    /// antes de almacenarla.

    //Dependencias
    private readonly IPasswordHasher _passwordHasher; 
    private readonly EmailValueObject _email = new();       
    private readonly PasswordValueObject _password = new(); 

    //Constructor
    public RegisterUser(IPasswordHasher passwordHasher)
    {
        _passwordHasher = passwordHasher;
    }

    //Métodos
    public string GetValidatedEmail(string requestEmail)
    {
        //Proposito: Validar el correo proporcionado por el User *requesEmail y
        //devolver el correo validado o lanzar una excepción si el correo no es válido.

        return _email.EmailValidation(requestEmail);
    }

    public string GetValidatedPassword(string requestPassword)
    {
        //Proposito: Validar la contraseña proporcionada por el User *requestPassword,
        //devolver la contraseña validada o lanzar una excepción si la contraseña no es válida.

        string validatedPassword = _password.PasswordValidation(requestPassword);

        return _passwordHasher.Hash(validatedPassword);
    }
}
