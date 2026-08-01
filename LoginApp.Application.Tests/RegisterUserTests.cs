using LoginApp.Application.Common;
using LoginApp.Application.Interfaces;
using LoginApp.Application.UseCases;
using LoginApp.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
namespace LoginApp.Application.Tests;


[TestClass]
public class RegisterUserTests
{
    //Proposito: Probar la clase RegisterUser y sus métodos para asegurar que
    //el proceso de registro de usuario funcione correctamente.

    [TestMethod]
    public void Execute_WithValidData_ReturnSuccess()
    {
        //Arrange: -> Preparación de datos
        var repository = new FakeUserRepository();
        var hasher = new FakePasswordHasher();
        var registerUser = new RegisterUser(hasher, repository); //Le mandamos como repositorio, el FakeRepository.

        var request = new RegisterUserRequest
            (
                "Gonzakh",
                "Espadondelasruinas+10",
                "gonza-kh@hotmail.com"
            );

        //Act: -> Ejecución de código
        Result result = registerUser.Execute(request);

        //Assert: Comprobación de resultado
        Assert.IsTrue(result.IsSuccess);
        Assert.HasCount(1, repository.Users);
        Assert.AreEqual("gonza-kh@hotmail.com", repository.Users[0].Email); //Chequea email del primer User de la lista Users de FakeRepository (repository)
        Assert.AreEqual("gonzakh", repository.Users[0].UserName); //El ObjectValue normaliza el usuario para su creacion, por lo tanto se debe esperar el usuario normalizado.
        Assert.AreEqual("HASHEDEspadondelasruinas+10", repository.Users[0].PasswordHash);
       

        
    }

    [TestMethod]
    public void Execute_WithInvalidData_ReturnSuccess()
    {
        //Arrange:
        FakePasswordHasher hasher = new();
        string correctPassword = "Montero+20";

        //Act:
        string passwordHashed = hasher.Hash("Montero+15");

        //Assert:
        Assert.AreNotEqual(correctPassword, passwordHashed, "La contraseña ingresada es incorrecta");

    }

    [TestMethod]
    public void Execute_WithInvalidEmail_ThrowArgumentException()
    {
        //Arrange:
        FakeUserRepository repository = new();
        User gonza = new 
            ("Gonzakh", 
            "Espadondelasruinas", 
            "gonza-khhotmail.com");
        
        
        repository.Add(gonza);

        //Act:
        bool result = gonza.Email.Contains('@');

        //Assert:
        Assert.IsFalse(result, "El mail ingresado no es válido.");

    }

    [TestMethod]
    public void Execute_WithShortPassword_ThrowArgumentException()
    {
        //Arrange:
        FakeUserRepository repository = new();
        User gonza = new("Gonzakh", "gonza12", "gonza-kh@hotmail.com");
        repository.Add(gonza);
        //Act:
        bool result = (gonza.PasswordHash.Length < 8);

        //Assert:
        Assert.IsTrue(result, "La contraseña ingresada es demasiado corta.");

    }

    [TestMethod]
    public void Execute_WithDuplicatedEmail_ReturnsFailure()
    {
        //Arrange:
        FakeUserRepository repository = new();
        User gonza = new("Gonzakh", "gonza12", "gonza-kh@hotmail.com");
        repository.Add(gonza);
        //Act:
        bool result = repository.ExistsByEmail(gonza.Email);
        //Assert:
        Assert.IsTrue(result, "El email ingresado ya está registrado.");

    }

    [TestMethod]
    public void Execute_WithDuplicatedUsername_ReturnsFailure()
    {
        //Arrange:
        FakeUserRepository repository = new();
        User gonza = new("Gonzakh", "gonza12", "gonza-kh@hotmail.com");
        repository.Add(gonza);
        //Act:
        bool result = repository.ExistsByUsername(gonza.UserName);
        //Assert:
        Assert.IsTrue(result,"El Nombre de usuario ya está registrado.");
    }
}





//Método de FakeHasher
public class FakePasswordHasher : IPasswordHasher
{
    public string Hash(string password)
    {
        // Simula el hashing de la contraseña devolviendo una cadena fija para las pruebas
        return $"HASHED{password}";
    }

}

//Repositorio Fake para pruebas unitarias
public class FakeUserRepository : IUserRepository
{
    public List<User> Users { get; } = [];

    public Result Add(User user)
    {
        Users.Add(user);
        return Result.Success("Usuario guardado correctamente");
    }

    public bool ExistsByEmail(string email)
    {
        // Simula la verificación de existencia de un usuario por correo electrónico
        return Users.Any(user => user.Email == email);
    }

    public bool ExistsByUsername(string username)
    {
        // Simula la verificación de existencia de un usuario por nombre de usuario
        return Users.Any(user => user.UserName == username);
    }

   

}
