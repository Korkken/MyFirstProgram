//Tim Lappalainen NET2024
Console.WriteLine("Skriv in ett nummer");

int number;
while (!int.TryParse(Console.ReadLine(), out number)) //checking if a person wrote a number or not. repeat until a number is written
{
    Console.WriteLine("Skriv in en siffra eller ett tal, tack!");
}

if (number < 10) //checks if the number is less than 10
{
    Console.WriteLine("Oj, vad lågt tal!");
}
else //if its not less than 10
{
    Console.WriteLine("Stort Tal!");
}

Console.WriteLine("Vad heter du?");
var name = Console.ReadLine();
Console.WriteLine($"Hej {name}!");

for (int i = 0; i <= number; i++) //writing out all number up to the number the person chose in the beginning
{
    Console.WriteLine(i);
}
