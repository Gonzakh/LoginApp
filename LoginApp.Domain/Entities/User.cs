namespace LoginApp.Domain.Entities;

public class User
{
    public int Id { get; private set; }
    public string UserName { get; private set; }
    public string Password { get; private set; } 
    public string Email { get; private set; }
}
