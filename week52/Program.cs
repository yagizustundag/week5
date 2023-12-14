// 0 (or below) - Freezing
// from 0 to 5 - Cold
// from 5 to 10 - Chilly
// from 10 to 15 - Cool
// from 15 to 28 - Warm
// above 28 - Boiling hot

Console.WriteLine("Enter the curent temp:");

int CurrentTemp = int.Parse(Console.ReadLine());

if (CurrentTemp <= 0)
{
    Console.WriteLine("Freezing");
}
else if (CurrentTemp > 0 && CurrentTemp < 5)
{
    Console.WriteLine("Cold");
}
else if (CurrentTemp > 5 && CurrentTemp < 10)
{
    Console.WriteLine("Chilly");
}
else if (CurrentTemp > 10 && CurrentTemp < 15)
{
    Console.WriteLine("Cool");
}
else if (CurrentTemp > 15 && CurrentTemp < 28)
{
    Console.WriteLine("Warm");
}
else
{
    Console.WriteLine("Boiling hot");
}
