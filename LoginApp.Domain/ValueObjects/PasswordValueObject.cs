namespace LoginApp.Domain.ValueObjects;

public class PasswordValueObject
{
    //Propiedades
    public string PasswordNormalized { get; private set; } = string.Empty;

    //metodos
    public string PasswordValidation(string passwordToNormalize)
    {
        //Proposito: Validar la contraseña ingresada por el usuario *passwordToNormalize y devolver una version normalizada *PasswordNormalized.
        if (string.IsNullOrWhiteSpace(passwordToNormalize))
        {
            throw new ArgumentException("La contraseña es obligatoria.", nameof(passwordToNormalize));
        }

        if (passwordToNormalize.Length < 6)
        {
            throw new ArgumentException("La contraseña debe tener al menos 6 caracteres.", nameof(passwordToNormalize));
        }

        PasswordNormalized = passwordToNormalize.Trim();

        return PasswordNormalized;
    }
}
