using System;

namespace NamuDarbas1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Įveskite skaičių nuo -9 iki 9.");
            string skaicius = Convert.ToString(Console.ReadLine());

            Console.WriteLine(IsItdigit(skaicius));
            IsNumberInRange(skaicius);
        }

        static bool IsItdigit(string a)
        {

            if (a.Length > 2)
            {
                Console.WriteLine("Non compatible number. Numbers with one digits allowed only!");
                return false;
            }
            else if (a.Length == 2)
            {
                char minusas = Convert.ToChar(a[0]);
                char skaicius = Convert.ToChar(a[1]);
                if (minusas == Convert.ToChar("-") && char.IsDigit(skaicius) == true)
                {
                    return true;
                }
                return false;
            }
            else
            {
                char b = Convert.ToChar(a);
                return char.IsDigit(b);
            }
        }

        static void IsNumberInRange(string a)
        {
            int skaicius = int.Parse(a);
            if (skaicius >= -9 && skaicius <= 9)
            {
                Console.WriteLine($"Duotas skaičius '{skaicius}' yra tarp -9 ir 9.");
            }
            else
            {
                Console.WriteLine($"Duotas skaičius '{skaicius}' nepatenka tarp -9 ir 9.");
            }

        }
    }
}
