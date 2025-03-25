using auticko;
using Spectre.Console;
using System.Collections.Concurrent;

Metody nevim = new Metody();
bool exitBool = true;
while (exitBool)
{
    var menu = AnsiConsole.Prompt(new SelectionPrompt<string>().PageSize(4).AddChoices(new[] { "Natankovat", "Stav paliva", "Projet se", "Exit" }));
    switch (menu)
    {
        case "Natankovat":
            Console.WriteLine("Zadej počet litrů kolik potřebuješ natankovat");
            int litr = Convert.ToInt32(Console.ReadLine());
            nevim.Natankuj(litr);
            Console.Clear();
            break;
        case "Stav paliva":
            nevim.stavPaliva();
            Console.Clear();
            break;
        case "Projet se":
            nevim.Jed();
            Console.Clear();
            break;
        case "Exit":
            exitBool = false;
            break;
    }
}
