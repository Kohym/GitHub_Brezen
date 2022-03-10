Console.WriteLine("Zadejte 1. číslo");
int cislo1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Zadejte číslo 2");
int cislo2 = Convert.ToInt32(Console.ReadLine());
if (cislo1 < cislo2)
{
    Console.WriteLine($"{cislo2} je vetsi nez {cislo1}");
}
else
{
    Console.WriteLine($"{cislo1} je vetsi nez {cislo2}");
}
