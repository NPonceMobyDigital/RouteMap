
public class CoolPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public CoolPerson(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public void SayFirstName()
    {
        Console.WriteLine("My first name is " + this.FirstName);
    }

    public void SayLastName()
    {
        Console.WriteLine("My last name is " + this.LastName);
    }
}




