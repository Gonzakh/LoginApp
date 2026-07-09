using LoginApp.Application.Common;
using LoginApp.Application.Interfaces;
using LoginApp.Domain.ValueObjects;

namespace LoginApp.Application.UseCases;

public class RegisterUser
{
    /// Proposito: Gestionar el proceso de registro de un nuevo usuario, 
    /// incluyendo la validación de correo electrónico y contraseña, y el hashing de la contraseña 
    /// antes de almacenarla.

    //Dependencias
    private readonly IUserRepository _userRepository;
    private readonly IPasswordHasher _passwordHasher; 
    private readonly EmailValueObject _email = new();       
    private readonly PasswordValueObject _password = new(); 
    private readonly UserNameValueObject _username = new();

    //Constructores -> Solo 1 para que no quedé null el otro constructor.
    public RegisterUser(IPasswordHasher passwordHasher, IUserRepository userRepository)
    {
        _passwordHasher = passwordHasher;
        _userRepository = userRepository;
    }

  

    //Métodos
    public string GetValidatedEmail(string requestEmail)
    {
        //Proposito: Validar el correo proporcionado por el User *requestEmail y
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

    public string GetValidatedUserName(string requestUserName)
    {
        //Proposito: Validar el nombre de usuario proporcionado por el User *requestUserName,
        //devolver el nombre de usuario validado o lanzar una excepción si el nombre de usuario no es válido.

        string validatedUserName = _username.UserNameValidation(requestUserName);

        return validatedUserName; 
    }

    public Result SaveUserInRepository(string validatedUserName, string hashedPassword, string validatedEmail)
    {
        //Proposito: Crear un nuevo usuario con los datos validados y guardarlo en el repositorio.
        //Aclaración: Los datos validados *userName, *hashedPassword y *validatedEmail se pasan como parámetros validados.

        var newUser = new Domain.Entities.User(validatedUserName, hashedPassword, validatedEmail); // Crear una nueva instancia de User con los datos validados
        return _userRepository.Add(newUser); // Guardar el nuevo usuario en el repositorio y retornar el resultado de la operación


    }

    //public RegisterUserResult Execute()
    //{ }
    

}
