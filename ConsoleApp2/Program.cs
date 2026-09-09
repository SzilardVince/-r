Console.Write("add meg a termék nevét");
string termekNev = Console.ReadLine();
Console.Write("add meg a termék egységárát");
int termekar = int.Parse(Console.ReadLine());
Console.Write("add meg a termék vásárolt mennyiségét");
int termemeny = int.Parse(Console.ReadLine());
Console.Write("jar e kedvezmeny");
bool kedvezmeny = bool.Parse(Console.ReadLine());
if (kedvezmeny == true)
{
if ((termekar*termemeny) >= 10000) Console.WriteLine("a termék ára: " + termekar * termemeny * 0.9);
else Console.WriteLine("a termék ára: " + termekar * termemeny);
}
else
{
    Console.WriteLine("a termék ára: " + termekar * termemeny);
}