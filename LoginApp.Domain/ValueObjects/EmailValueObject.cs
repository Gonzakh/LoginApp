

namespace LoginApp.Domain.ValueObjects;

public class EmailValueObject
{
    //Proposito:    *Contener la logica de validacion y normalizacion de un email ingresado por el usuario.

    public string EmailNormalized { get; set; }

    public string EmailValidation(string emailToNormalize)
    {
        if (string.IsNullOrWhiteSpace(emailToNormalize))
        {
            throw new ArgumentNullException("El email es obligatorio.");
        }
        if (!emailToNormalize.Contains("@"))
        {
            Throw new ArgumentException("El email debe contener '@'.");
        }

        EmailNormalized = emailToNormalize.Trim().ToLowerInvariant();

        return EmailNormalized;
    }






}
