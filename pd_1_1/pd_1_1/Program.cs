using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pd_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzdevums_1
            Console.Write("Ievadi savu vardu: ");
            string vards = Console.ReadLine();
            Console.Write("Ievadi savu uzvardu: ");
            string uzvards = Console.ReadLine();
            Console.WriteLine("Tevi sauc " + vards + " " + uzvards + "!");

            //Uzdevums_2
            Console.Write("Ievadi gadu: ");
            int gads = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadi savu dzimsanas gadu: ");
            int dz_gads = Convert.ToInt32(Console.ReadLine());
            int vecums = gads - dz_gads;
            Console.WriteLine("Tev ir " + vecums + ".");

            //Uzdevums_3
            Console.Write("Ievadiet rinka linijas radiusu: ");
            double rlr = Convert.ToDouble(Console.ReadLine());
            double rlr_D = 2 * rlr;
            double rlr_S = 2 * rlr * 3.14;
            Console.WriteLine("Rinka linijas diametrs ir {0} un laukums ir {1}", rlr_D, rlr_S + ".");

            //Uzdevums_4
            Console.Write("Ievadiet skaitli: ");
            double skaitlis = Convert.ToDouble(Console.ReadLine());
            Funkcija(skaitlis);

            //Uzdevums_5
            Console.Write("Ievadiet simbolu virkni: ");
            string virkne = Console.ReadLine();
            if (virkne == "macos programmet")
            {
                Console.WriteLine("Simbolu virkne ir vienada!");
            }
            else
            {
                Console.WriteLine("Simbolu virkne NAV vienada!");
            }

            //Uzdevums_6
            Console.WriteLine("Vai gribat sasveicinaties (ja/ne)?");
            string izvele = Console.ReadLine();
            if (izvele == "ja")
            {
                Console.Write("Ievadi savu vardu: ");
                vards = Console.ReadLine();
                Console.Write("Ievadi savu uzvardu: ");
                uzvards = Console.ReadLine();
                Console.WriteLine("Tevi sauc " + vards + " " + uzvards + "!");
            }
            else
            {
                Console.WriteLine("Zel gan!");
            }

            Console.Read();

        }

        //Uzdevuma_4_funkcija
        static void Funkcija(double abc)
        {
            Console.WriteLine("Mans skaitlis ir " + abc + ".");
        }

    }
}
