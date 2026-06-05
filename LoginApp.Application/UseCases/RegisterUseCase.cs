using LoginApp.Domain.Exceptions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LoginApp.Application.UseCases;

public class RegisterUseCase
{   /*Proposito: UseCase para:
                            *Registrar datos de un nuevo usuario.
                            *Validar y normalizar el email ingresado por el usuario.
                            *
    */

    //Inyeccion de dependencias
    RegisterExceptions Errors = new RegisterExceptions();


    //Metodos de validacion y normalizacion de datos
    public string GetValidatedEmail(string requestEmail)
    {
        //Proposito:    *Recibir el email ingresado por el usuario *requestEmail*, validarlo y normalizarlo. 
        //Retorna el email validado y normalizado, o un string vacio si el email no es valido.

        string returnedEmail = string.Empty;


        if (ValidateEmail(requestEmail))
        {
            returnedEmail = NormalizateEmail(requestEmail);
        }
        else
        {
            //Pasar este mensaje a una capa de presentacion, o manejarlo con excepciones personalizadas.
            Console.WriteLine($"El Email ingresado no es válido.\nErrores: {Errors.RegistrationErrors}\nVuelve a intentar"); 
        }
        return returnedEmail;
    }

    public static string NormalizateEmail(string emailToNormalize)
    {
        //Proposito:    *Normalizar Email ingresado *emailToNormalize* segun reglas de negocio.

        emailToNormalize = emailToNormalize.Trim().ToLower();
        return emailToNormalize;
    }

    public bool ValidateEmail(string emailToValidate)
    {
        //Proposito:    *Validar Mail ingresado *emaiToValidate* segun reglas de negocio.

        bool resultadoDeValidacion = true;

        if (string.IsNullOrWhiteSpace(emailToValidate))
        {
            Errors.RegistrationErrors.Add("El Email no puede estar vácio.");
        }
        if (!emailToValidate.Contains("@"))
        {
            Errors.RegistrationErrors.Add("El Email debe contener el símbolo '@'.");
        }
        if (Errors.RegistrationErrors.Count != 0)
        {
            resultadoDeValidacion = false;
        }
        return resultadoDeValidacion;
    }

    //Metodos de Hash de contraseña, validacion de password

     
}
