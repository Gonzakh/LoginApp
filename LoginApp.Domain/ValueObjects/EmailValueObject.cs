namespace LoginApp.Domain.ValueObjects;

public class EmailValueObject
{
    //propiedades
    public string EmailNormalized { get; private set; } = string.Empty;

    //metodos
    public string EmailValidation(string emailToNormalize)
    {
        //Proposito: Validar el email ingresado por el usuario *emailToNormalize y devolver una version normalizada *EMailNormalized.

        if (string.IsNullOrWhiteSpace(emailToNormalize))
        {
            throw new ArgumentException("El email es obligatorio.", nameof(emailToNormalize));
        }

        if (!emailToNormalize.Contains("@"))
        {
            throw new ArgumentException("El email debe contener '@'.", nameof(emailToNormalize));
        }

        EmailNormalized = emailToNormalize.Trim().ToLowerInvariant();

        return EmailNormalized;
    }
}
