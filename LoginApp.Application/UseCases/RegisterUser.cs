using LoginApp.Application.Interfaces;
using LoginApp.Domain.Exceptions;
using LoginApp.Domain.ValueObjects;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LoginApp.Application.UseCases;

public class RegisterUser
{   /*Proposito: UseCase para:
                            *Obtener datos validados y normalizados para crear una nueva entidad User.
                            *Devolver un objeto UserDTO con los datos validados y normalizados.
    */

    //Inyeccion de dependencias
    RegisterExceptions Errors = new RegisterExceptions();
    EmailValueObject Email = new EmailValueObject();
  
    private readonly IPasswordHasher _passwordHasher;
    public RegisterUser(IPasswordHasher passwordHasher)
    {
        _passwordHasher = passwordHasher;
    }


    //Metodos de validacion y normalizacion de email
    public string GetValidatedEmail(string requestEmail)
    {
        //Proposito:    *Recibir el email ingresado por el usuario *requestEmail*, validarlo y normalizarlo. 
        //Retorna el email validado y normalizado, o arroja una excepción.
        //Precondiciones:  *requestEmail es traido desde UserDTO.

        string returnedEmail = Email.EmailValidation(requestEmail);

        return returnedEmail;
    }

    //Metodos de validacion y normalizacion de password
    public string GetValidatedPassword(string requestPassword)
    {
        //Proposito:    *Recibir la contraseña ingresada por el usuario *requestPassword*, validarla y normalizarla.
        //

        string returnedPassword = string.Empty;

        if()
    }



}
