using System.ComponentModel.DataAnnotations;
using LoginApp.Domain.Exceptions;

namespace LoginApp.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }

    [Required(ErrorMessage = RegisterExceptions.missingFieldErrorMessage)]
    public string UserName { get; private set; }

    [Required(ErrorMessage = RegisterExceptions.missingFieldErrorMessage)]
    public string PasswordHash { get; private set; }

    [Required(ErrorMessage = RegisterExceptions.missingFieldErrorMessage)]
    public string Email { get; private set; }

    public User(string userName, string passwordHash, string email)
    {
        Id = Guid.NewGuid();
        
        UserName = userName;
        PasswordHash = passwordHash;
        Email = email;
    }

    

}
