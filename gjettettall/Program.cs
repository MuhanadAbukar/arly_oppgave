/*
 
# Program for å gjette på et tall

import random

Console.WriteLine()
Console.WriteLine("Så skal du gjette på hvilket tall programmet tenker på!")
Console.WriteLine("Programmet vil si fra om tallet er for høyt, for lavt eller rett.")
topp = int(input("Skriv inn øvre grense for hvilket tall programmet skal tenke på."))
Console.WriteLine("Da gjetter programmet på et tall mellom 0 og", topp, ".")
rett = False
tall = random.randint(0, topp)
gjettinger = 0

while rett == False:
  gjett=int(input("Skriv inn hvilket tall du tror programmet tenker på."))
  gjettinger = gjettinger + 1
  if gjett < tall:
    Console.WriteLine("Tallet du skrev inn, er for lavt.")
  elif gjett > tall:
    Console.WriteLine("Tallet du skrev inn, er for høyt.")
  else:
    Console.WriteLine("Du gjettet helt rett!")
    rett = True
    
Console.WriteLine(f"Du brukte {gjettinger} gjettinger på å komme fram til rett svar.")
 */
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
    gjettinger++;
    Console.WriteLine("Skriv inn hvilket tall du tror programmet tenker på.");
    var gjtt = int.TryParse(Console.ReadLine(),out int num);
    if(!gjtt)
    {
        Console.WriteLine("Det var ikke tall.");
    }
    else
    {
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