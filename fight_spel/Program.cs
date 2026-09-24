using System.Security.Cryptography;

int herohp = 100;
int villainhp =100;
int runda =1;

string heroname = "The hero";
string villainname ="The villain";

while(villainhp > 0 && herohp > 0)
{
    Console.WriteLine();
    Console.WriteLine($"/------======/Round {runda}/======------/");
    Console.WriteLine($"{heroname}: {herohp}   {villainname}: {villainhp}");

    int herodmg = Random.Shared.Next(20);
    villainhp -= herodmg;
    villainhp = Math.Max(0, villainhp);
    Console.WriteLine($"{heroname} does {herodmg} against {villainname}.");

    int villaingdmg = Random.Shared.Next(20);
    herohp -= villaingdmg;
    herohp = Math.Max(0, herohp);
    Console.WriteLine($"{villainname} does {villaingdmg} against {heroname}.");

    runda++;


    Console.WriteLine("press a button to continue");
    Console.ReadKey();
    
}


Console.WriteLine();

if (villainhp == 0 && herohp == 0)
{
    Console.WriteLine("Its a draw.");
    
}

else if(villainhp == 0)
{
    Console.WriteLine($"{heroname} won in {runda} rounds and had {herohp} hp left!");
}

else
{
    Console.WriteLine($"{villainname} won in {runda} rounds and had {villainhp} hp left!");
}

Console.WriteLine();
Console.WriteLine("press a button to finish the game.");
Console.ReadKey();  