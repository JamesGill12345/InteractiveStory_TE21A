

Console.WriteLine("Du går på en väg ute på landet, plötsligt delar sig vägen. Man kan gå vänster eller höger. vilken kommer du välja? (skriv vänster eller höger)");
val1:
string val1 = Console.ReadLine();


if (val1 == "höger")
{
    Console.WriteLine("du beger dig högerut mot slottet");
    Console.WriteLine("Du går in i slottet och träffar där en man som erbjuder dig fika och te. Ni har en trevlig stund och du går där ifrån med ett leende på läpparna.");
}
else if (val1 == "vänster")
{
val2left:
    Console.WriteLine("du går vänsterut mot sjön");
    Console.WriteLine("efter ett par timmar har du kommit till den norra änden av sjön.");
    Console.WriteLine(" du möter en främling som påstår att han nyss såg en jättelik björn nära här och ber om din hjälp att ta sig till säkerhet.");
    Console.WriteLine("kommer du att hjälpa fränmingen därifrån eller gå ensam?");
    Console.WriteLine("skriv: tillsammans eller ensam");
    string val2left = Console.ReadLine();
    if (val2left == "ensam")
    {
        Console.WriteLine("du flyr från skogen ensam. Du klarar dig oskadd. Men när du har lämnat skogen hör du ett skrik från skogen, du ryser till och fortsätter gå");
    }
    else if (val2left == "tillsammans")
    {
        Console.WriteLine("du försöker ta med dig främlingen ut ur skogen men främlingen blir panikslagen när han får syn på en geting och börjar skrika, björnen hör er och äter upp er båda.");
    }

    else
    {
        Console.WriteLine("tyvärr finns inte det alternativet");
        goto val2left;
    }
}
else
{
    Console.WriteLine("Tyvärr finns inte det svarsalternativet, försök igen ):");
    goto val1;
}
Console.ReadLine();
























// Console.WriteLine("hej, vad heter du");

// string name = Console.ReadLine();

// Console.WriteLine($"hej {name}");

// if (name != "james")
// {
// Console.WriteLine("fint namn");
// }
// else if (name == "johan")
//  {
//  Console.WriteLine("usch vad äckligt");

//     }
// else
//  {
//  Console.WriteLine("du är ful");
//  }


// Console.ReadLine();