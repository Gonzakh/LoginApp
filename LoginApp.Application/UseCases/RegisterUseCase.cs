using LoginApp.Domain.Exceptions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LoginApp.Application.UseCases;

public class RegisterUseCase
{   //Proposito:    *UseCase para el registro de un nuevo usuario.
    //              


    RegisterExceptions Errors = new RegisterExceptions();
    public string GetValidatedEmail(string requestMail)
    {
        //Proposito:    *Recibir el email ingresado por el usuario, validarlo, normalizarlo y devolverlo.
        string returnedEmail = string.Empty;


        if (ValidateEmail(requestMail))
        {
            returnedEmail = NormalizateEmail(requestMail);
        }
        else
        {
            Console.WriteLine($"El Email ingresado no es válido.\nErrores: {Errors.RegistrationErrors}\nVuelve a intentar");
        }
        return returnedEmail;
    }

    public static string NormalizateEmail(string emailToNormalize)
    {
        //Proposito:    *Normalizar Mail ingresado *emailToNormalize* segun reglas de negocio.

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
}
