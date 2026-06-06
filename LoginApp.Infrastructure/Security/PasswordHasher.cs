using System.Security.Cryptography;
using System.Text;
using LoginApp.Application.Interfaces;

namespace LoginApp.Infrastructure.Security;

public class PasswordHasher : IPasswordHasher
{
    
    public string Hash(string passwordToHash)
    {
        // Convertir la contraseña *passwordToHash a un arreglo de bytes utilizando UTF-8
        // Aplicar el algoritmo de hashing SHA256 al arreglo de bytes de la contraseña utilizando el método HashData de la clase SHA256

        byte[] passwordBytes = Encoding.UTF8.GetBytes(passwordToHash);
        byte[] hashBytes = SHA256.HashData(passwordBytes);

        return Convert.ToHexString(hashBytes); // Convertir el arreglo de bytes resultante del hash a una cadena hexadecimal y devolverla
    }
}
