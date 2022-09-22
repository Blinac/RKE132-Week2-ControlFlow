// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, Karl!");

//rakendus küsib kasutajal valida tema sugu (m/f)
//rakendus küsib kasutajal sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi] / "Welcome, Ms. [kasutaja perekonnanimi]"


Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) formaadis

Console.WriteLine("Please, enter your lastname:");
string userlastname = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userlastname}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userlastname}!");
}
else
{
    Console.WriteLine($"Welcome, {userlastname}!");
}