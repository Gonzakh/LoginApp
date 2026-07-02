namespace LoginApp.Domain.ValueObjects;

public class UserNameValueObject
{
    //Propiedades
    public string UserNameNormalized { get; private set; } = string.Empty;

    //metodos
    public string UserNameValidation(string userNameToNormalize)
    {
        //Proposito: Validar el nombre de usuario ingresado por el usuario *userNameToNormalize y devolver una version normalizada *UserNameNormalized.
        if (string.IsNullOrWhiteSpace(userNameToNormalize))
        {
            throw new ArgumentException("El nombre de usuario es obligatorio.", nameof(userNameToNormalize));
        }
        UserNameNormalized = userNameToNormalize.Trim().ToLowerInvariant();
        return UserNameNormalized;
    }

}
