namespace LoginApp.Application.Common;

public class Result
{
    //Proposito: Representar el resultado de una operación, indicando si fue exitosa o no, y proporcionando un mensaje adicional.

    //  Propiedades
    public bool IsSuccess { get; private set; }
    public string Message { get; private set; }

    //Constructor

    private Result(bool isSuccess, string message)
    {
        IsSuccess = isSuccess;
        Message = message;
    }

    //Métodos de fábrica para crear instancias de Result

    public static Result Success(string message = "")
    {
        //Proposito: Crear una instancia de Result que represente un resultado exitoso.
        //Precondicion: El mensaje no debe ser nulo.
        return new Result(true, message);
    }

    public static Result Failure(string message = "")
    {
        //Proposito: Crear una instancia de Result que represente un resultado fallido.
        //Precondicion: El mensaje de error no debe ser nulo o vacío.
        return new Result(false, message);
    }

}
