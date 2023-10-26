using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ange ett beräknings tal (Enbart heltal)");
        Console.WriteLine("Skriv in ditt första tal...");

        int Första = int.Parse(Console.ReadLine());

        Console.WriteLine("Skriv nu ditt andra tal");

        int Andra = int.Parse(Console.ReadLine());

        Console.WriteLine("Välj ett räknesätt (ange siffran bredvid)");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. subtraktion");
        Console.WriteLine("3. Multiplikation");
        Console.WriteLine("4. division");

        int Räkning = int.Parse(Console.ReadLine());

        if (Räkning == 1)
        {
            Console.WriteLine(Första + Andra);
        }
        
        if (Räkning == 2)
        {
            Console.WriteLine(Första - Andra);
        }

        if (Räkning == 3)
        {
            Console.WriteLine(Första * Andra);
        }

        if (Räkning == 4)
        {
            Console.WriteLine(Första / Andra + " (Kan ej visa decimal tal)");
        }
    }
}