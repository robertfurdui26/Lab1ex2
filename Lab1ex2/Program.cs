using System;

namespace Lab1ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex2
            Scrieti un program care va calcula media aritmetica a trei numere citite de la
            tastatura*/

            Console.WriteLine("Calculeaza media aritmetica");

            Console.WriteLine("Introduceti primul numar: ");
            int primulNumar = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar: ");
            int alDoileaNumar = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al trilea numar: ");
            int alTreileaNumar = int.Parse(Console.ReadLine());

            int mediaAritmetica = (primulNumar + alDoileaNumar + alTreileaNumar) / 3;

            Console.WriteLine("Media aritmetica este: " + mediaAritmetica);


        }
    }
}