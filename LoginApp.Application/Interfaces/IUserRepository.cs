using LoginApp.Application.Common;
using LoginApp.Domain.Entities;

namespace LoginApp.Application.Interfaces
{
    public interface IUserRepository
    {
        //Implementación de la interfaz IUserRepository para manejar operaciones relacionadas con los usuarios en el repositorio.
        //Aqui no se definen los detalles de almacenamiento, solo se especifican los métodos que deben implementarse en las clases concretas que manejen la persistencia de datos.
        Result Add(User user);
        bool ExistsByEmail(string email);
        bool ExistsByUsername(string username);

    }
}
