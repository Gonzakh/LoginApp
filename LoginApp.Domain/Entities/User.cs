using System.ComponentModel.DataAnnotations;
using LoginApp.Domain.Exceptions;

namespace LoginApp.Domain.Entities;

public class User
{
    //Propiedades

    public Guid Id { get; private set; }
    public string UserName { get; private set; }
    public string PasswordHash { get; private set; }
    public string Email { get; private set; }

    //Constructor

    public User(string userName, string passwordHash, string email)
    {
        //Validaciones de negocio

        if(string.IsNullOrWhiteSpace(userName))
        {
            throw new ArgumentException("El nombre de usuario no puede estar vacío.", nameof(UserName));
        }
        if (string.IsNullOrWhiteSpace(passwordHash))
        {
            throw new ArgumentException("El hash de contraseña no puede estar vacío.", nameof(passwordHash));
        }
        if (string.IsNullOrWhiteSpace(email))
        {
            throw new ArgumentException("El email no puede estar vacío.", nameof(Email));
        }

        Id = Guid.NewGuid();

        UserName = userName;
        PasswordHash = passwordHash;
        Email = email;


    }

    

}
