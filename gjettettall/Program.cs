var Rand = new Random();
Console.WriteLine("Dette programmet tenker på et tall mellom 0 og et tall du velger.");
Console.WriteLine("Programmet vil si fra om tallet er for høyt, for lavt eller rett.");
Console.WriteLine("Skriv inn øvre grense for hvilket tall programmet skal tenke på.");
int topp = 0;
var tops = false;
while(!tops)
{
    var top = int.TryParse(Console.ReadLine(), out topp);
    tops = top;
    if(!tops)
    {
        Console.WriteLine("Skriv inn øvre grense for hvilket tall programmet skal tenke på.");
    }
}
var tall = Rand.Next(0, topp);
var rett = false;
var gjettinger = 0;
while(!rett)
{
    Console.WriteLine("Skriv inn hvilket tall du tror programmet tenker på.");
    var gjtt = int.TryParse(Console.ReadLine(),out int num);
    if(!gjtt)
    {
        Console.WriteLine("Det var ikke tall.");
    }
    else
    {
        gjettinger++;
        if (num < tall)
        {
            Console.WriteLine("Tallet du skrev inn, er for lavt.");

        }
        else if (num > tall)
        {
            Console.WriteLine("Tallet du skrev inn, er for høyt.");
        }
        else if (num == tall)
        {
            Console.WriteLine("Du gjettet helt rett!");
            rett = true;
        }
    }
}
Console.WriteLine($"Du brukte {gjettinger} gjettinger på å komme fram til rett svar.");