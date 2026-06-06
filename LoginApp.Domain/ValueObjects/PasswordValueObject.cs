using System;

public class PasswordValueObject
{
	public PasswordValueObject()
	{
        string PasswordNormalized { get; set; }

        public string PasswordValidation(string passwordToNormalize)
    {
        if (string.IsNullOrWhiteSpace(passwordToNormalize))
        {
            throw new ArgumentNullException("La contraseña es obligatoria.");
        }
        if (passwordToNormalize.Length < 8)
        {
            throw new ArgumentException("La contraseña debe tener al menos 8 caracteres.");
        }
        if (!passwordToNormalize.Any(char.IsUpper))
        {
            throw new ArgumentException("La contraseña debe contener al menos una letra mayúscula.");
        }
        if (!passwordToNormalize.Any(char.IsLower))
        {
            throw new ArgumentException("La contraseña debe contener al menos una letra minúscula.");
        }
        if (!passwordToNormalize.Any(char.IsDigit))
        {
            throw new ArgumentException("La contraseña debe contener al menos un número.");
        }
        PasswordNormalized = passwordToNormalize.Trim();
        return PasswordNormalized;
    }

}
}
