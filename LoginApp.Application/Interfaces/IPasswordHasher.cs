namespace LoginApp.Application.Interfaces;

public interface IPasswordHasher
{
    //Proposito: Definir un contrato para el hashing de contraseñas.

    string Hash(string passwordToHash);
}
