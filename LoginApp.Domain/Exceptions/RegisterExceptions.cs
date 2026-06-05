namespace LoginApp.Domain.Exceptions;

public class RegisterExceptions
{

    public List<string> RegistrationErrors { get; private set; } = new();


    public void AddError(string errorMessage)
    {   //Proposito:    *Agregar un mensaje de error *errorMessage* a la lista de errores de registro.

        RegistrationErrors.Add(errorMessage);
    }
    public void ShowEmailErrors()
    {
        //Proposito:    *Mostrar los errores relacionados con el email ingresado por el usuario.
        Console.WriteLine($"El Email ingresado no es válido.\nErrores: {RegistrationErrors} \nVuelve a intentar");
    }

}

public static class UserErrors
{
    //Proposito:    *Contener mensajes de error relacionados con la entidad User.

    public const string MissingField = "El campo es obligatorio.";

    
        
}