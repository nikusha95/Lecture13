// See https://aka.ms/new-console-template for more information

using LINQ;
using System.Linq;

List<Person> persons = new List<Person>
{
    new()
    {
        FirstName = "f1",
        IdNumber = "123456678",
        LastName = "l1",
        Age = 17,
    },
    new()
    {
        FirstName = "f1",
        IdNumber = "123456678",
        LastName = "l1",
        Age = 21,
    },
    new()
    {
        FirstName = "f2",
        IdNumber = "123221216678",
        LastName = "l2",
        Age = 12,
    },
    new()
    {
        FirstName = "a1",
        IdNumber = "123411156678",
        LastName = "l3",
        Age = 25,
    },
    new()
    {
        FirstName = "a1",
        IdNumber = "123456678",
        LastName = "l4",
        Age = 18,
    }
};
var result = persons.Where(x => x.FirstName == "f1" || x.Age >= 18);
bool idContaints7and8 = persons.Any(x => x.IdNumber.Contains("65"));

// Console.WriteLine(idContaints7and8);
// foreach (var person in result)
// {
//     Console.WriteLine(person);
// }

int cnt = persons.Count(x => x.FirstName == "f1");
//Console.WriteLine(cnt);

var p = persons.FirstOrDefault(x => x.FirstName == "nika");
//Console.WriteLine(p);

//anonymous type
var t = new { K = "sadada" };
Console.WriteLine(t.K);

var names = persons.Skip(2).Take(10).Select(x => new
{
    FullName = $"{x.FirstName} {x.LastName}",
}).ToList();

// foreach (var name in names)
// {
//     Console.WriteLine(name.FullName);
// }


var gPersons1 = persons
    .GroupBy(x => x.FirstName).ToList();
foreach (var gp in gPersons1)
{
    Console.WriteLine(gp.Key);
}

Console.WriteLine();
var gPersons2 = persons
    .GroupBy(x => x.FirstName)
    .Select(y => y.ToList())
    .Select(z => new { Count = z.Count, Name = z.FirstOrDefault()?.FirstName });

foreach (var count in gPersons2)
{
    Console.WriteLine($"{count.Name} {count.Count}");
}

Console.WriteLine();
var gPersons = persons
    .GroupBy(x => x.FirstName)
    .Select(y => y.ToList()).ToList();
foreach (var person in gPersons)
{
    foreach (var person1 in person)
    {
        Console.WriteLine($"{person1.FirstName} {person1.Age}");
    }
}


Func<int, int> func = i => i * 3;