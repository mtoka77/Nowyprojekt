//homework 1

using System.ComponentModel.Design;

var name = "Marcin";
var sex = "Male";
var age = 46;

if (sex == "Female" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (sex == "Male" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{ 
    Console.WriteLine();
}