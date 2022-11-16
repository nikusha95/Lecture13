namespace LINQ;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string IdNumber { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"{FirstName}/{LastName}/{IdNumber}/{Age}";
    }
}