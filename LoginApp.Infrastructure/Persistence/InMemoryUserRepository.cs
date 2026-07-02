using LoginApp.Domain.Entities;
using LoginApp.Application.Interfaces;
using System.ComponentModel.DataAnnotations;
using LoginApp.Application.Common;

namespace LoginApp.Infrastructure.Persistence;


public class InMemoryUserRepository : IUserRepository
{
    //Lista Declarada para almacenar los usuarios en memoria, simulando un repositorio de datos.
    private readonly List<User> _InMemoryUsers = new();


    public Result add(User user)
    {   //Proposito: Agregar un nuevo usuario a la lista de usuarios en memoria, verificando duplicados por correo electrónico y nombre de usuario antes de agregarlo.
        //Retorna un objeto Result indicando si la operación fue exitosa o no, junto con un mensaje correspondiente.

        if (ExistsByEmail(user.Email))
        {
            return Result.Failure("El correo electrónico ya está registrado.");
        }
        if (ExistsByUsername(user.UserName))
        {
            return Result.Failure("El nombre de usuario ya está registrado.");
        }

        _InMemoryUsers.Add(user);
        return Result.Success("Usuario guardado correctamente.");
    }

    public bool ExistsByEmail(string email)
    {
        //Retorna un valo Booleano indicando si existe un usuario con el correo electrónico proporcionado en la lista de usuarios en memoria.

        return _InMemoryUsers.Any(user => user.Email.Equals(email, StringComparison.OrdinalIgnoreCase) );
                            //StringComaparison.OrdinalIgnoreCase compara sin tener en cuenta mayúsculas y minúsculas.
    }   
    public bool ExistsByUsername(string username)
    {
        //Retorna un valor Booleano indicando si existe un usuario con el nombre de usuario proporcionado en la lista de usuarios en memoria.

        return _InMemoryUsers.Any(user => user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase));
                             //StringComaparison.OrdinalIgnoreCase compara sin tener en cuenta mayúsculas y minúsculas.
    }

}
