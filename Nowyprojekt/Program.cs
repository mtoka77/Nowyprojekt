//homework 2

using System.ComponentModel.DataAnnotations;

int number = 1977197711;
string numberAsString = number.ToString();

List<char> letters = numberAsString.ToList();

int[] counters = new int[10];

for (int i=0; i< counters.Length; i++)
{
    counters[i] = 0;
}
foreach (char letter in letters)
{
    if (letter == '0')
{ 
        counters[0]++;
}
else if (letter == '1')
{
    counters[1]++;
}
else if (letter == '2')
{
    counters[2]++;
}
else if (letter == '3')
{
    counters[3]++;
}
else if (letter == '4')
{
    counters[4]++;
}
else if (letter == '5')
{
    counters[5]++;
}
else if (letter == '6')
{
    counters[6]++;
}
else if (letter == '7')
{
    counters[7]++;
}
else if (letter == '8')
{
    counters[8]++;
}
else if (letter == '9')
{
    counters[9]++;
}
}
Console.WriteLine("W liczbie:" + number);
for (int i = 0; i < counters.Length; i++)
{
    Console.WriteLine("Cyfra " + i + " wystepuje " + counters[i] + " razy ");
}



