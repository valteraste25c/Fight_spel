using System.Security.Cryptography;
using System.Xml.Serialization;
string again = "";
while (again != "nej" && again != "no") // Skapar en loop för hela spelet så att man kan starta om ifall man vill.
{

    int herohp = 100;
    int villainhp = 100;
    int runda = 1;

    Console.WriteLine("What is your fighters name?"); // väljer namn på gubbe.
    string heroname = Console.ReadLine();

    string villainname = "";

    List<string> names = ["Thanos", "Ultron", "Darth maul"]; // väljer namnet på fienderns namn på slump
    int n = Random.Shared.Next(names.Count);

    villainname = names[n];

    Console.WriteLine($"you are fighting {villainname}");


    while (villainhp > 0 && herohp > 0)
    {
        string vMove = "";
        List<string> Moves = ["Heal", "Attack"]; // väljer namnet på fienderns namn på slump
        int VM = Random.Shared.Next(Moves.Count);
        vMove = Moves[VM];

        Console.WriteLine();
        Console.WriteLine($"/------======/Round {runda}/======------/");
        Console.WriteLine($"{heroname}: {herohp}   {villainname}: {villainhp}");
        Console.WriteLine();
        Console.WriteLine("Heal or Attack?");

        string hMove = "";
        while (hMove != "attack" && hMove != "heal")
        {
            hMove = Console.ReadLine();
            hMove = hMove.ToLower();
        }

        int herodmg = Random.Shared.Next(10,26); // antalet skada "hero" gör
        int heroheal = Random.Shared.Next(8,13); // antalet healing "hero" gör

        if (hMove == "attack")
        {
            villainhp -= herodmg;
            villainhp = Math.Max(0, villainhp);
            Console.WriteLine($"{heroname} does {herodmg} against {villainname}.");
        }

        else if (hMove == "heal")
        {
            herohp += heroheal;
            herohp = Math.Max(0, herohp);
            Console.WriteLine($"{heroname} heals and regains {heroheal} hp.");
        }

        int villaingdmg = Random.Shared.Next(10,26); // antalet skada "villain" gör
        int VillainHeal = Random.Shared.Next(8,13); // villains healing

        if (vMove == "Attack" || villainhp > 80) // "villainhp > 80" gör så att villain inte kan heala under
        {
            herohp -= villaingdmg;
            herohp = Math.Max(0, herohp);
            Console.WriteLine($"{villainname} does {villaingdmg} against {heroname}.");
        }
        else
        {
            villainhp += VillainHeal;
            villainhp = Math.Max(0, villainhp);
            Console.WriteLine($"{villainname} heals and regains {VillainHeal} hp.");
        }

        runda++;


        Console.WriteLine("press a button to continue");
        Console.ReadKey();

    }


    Console.WriteLine();

    if (villainhp == 0 && herohp == 0)
    {
        Console.WriteLine("Its a draw.");

    }

    else if (villainhp == 0)
    {
        Console.WriteLine($"{heroname} won in {runda} rounds and had {herohp} hp left!");
    }

    else
    {
        Console.WriteLine($"{villainname} won in {runda} rounds and had {villainhp} hp left!");
    }

    Console.WriteLine();
    Console.WriteLine("Do you want to play again?");
    again = Console.ReadLine();
    again = again.ToLower();

}

Console.ReadKey();


