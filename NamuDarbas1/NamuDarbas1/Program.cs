using System;

namespace NamuDarbas1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Įveskite skaičių nuo -9 iki 9.");
            string skaicius = Convert.ToString(Console.ReadLine());
            IsItDigit(skaicius);
            IsNumberInRange(skaicius);
            Console.WriteLine(ChangeNumberToString(Convert.ToInt32(skaicius)));
        }
        static bool IsItDigit(string a)
        {
            if (a[0] == '-')
            {
                a = a.TrimStart('-');
            }
            for (int i = 0; i < a.Length; i++)
            {
                char simbolis = a[i];
                bool arSkaicius = char.IsDigit(simbolis);
                if (arSkaicius == false)
                {
                    Console.WriteLine(false);
                    return false;
                }
            }
            Console.WriteLine(true);
            return true;
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

        static string ChangeNumberToString(int skaicius)
        {
            string minus = "";
            if (skaicius < 0)
            {
                skaicius = skaicius * -1;
                minus = "minus ";
            }
            if (skaicius >= 0 && skaicius < 20)
            {
                switch (skaicius)
                {
                    case 0:
                        return minus + "nulis";
                    case 1:
                        return minus + "vienas";
                    case 2:
                        return minus + "du";
                    case 3:
                        return minus + "trys";
                    case 4:
                        return minus + "keturi";
                    case 5:
                        return minus + "penki";
                    case 6:
                        return minus + "šeši";
                    case 7:
                        return minus + "septyni";
                    case 8:
                        return minus + "aštuoni";
                    case 9:
                        return minus + "devyni";
                    case 10:
                        return minus + "dešimt";
                    case 11:
                        return minus + "vienuolika";
                    case 12:
                        return minus + "dvylika";
                    case 13:
                        return minus + "trylika";
                    case 14:
                        return minus + "keturiolika";
                    case 15:
                        return minus + "penkiolika";
                    case 16:
                        return minus + "šešiolika";
                    case 17:
                        return minus + "septyniolika";
                    case 18:
                        return minus + "aštuoniolika";
                    case 19:
                        return minus + "devyniolika";
                    default:
                        return "Įvestas netinkamas skaičius!";
                }
            }
            else if (skaicius >= 20 && skaicius < 30)
            {
                string dvidesimt = "dvidešimt ";
                switch (skaicius)
                {
                    case 20:
                        return minus + " dvidešimt";
                    case 21:
                        return minus + dvidesimt + "vienas";
                    case 22:
                        return minus + dvidesimt + "du";
                    case 23:
                        return minus + dvidesimt + "trys";
                    case 24:
                        return minus + dvidesimt + "keturi";
                    case 25:
                        return minus + dvidesimt + "penki";
                    case 26:
                        return minus + dvidesimt + "šeši";
                    case 27:
                        return minus + dvidesimt + "septyni";
                    case 28:
                        return minus + dvidesimt + "aštuoni";
                    case 29:
                        return minus + dvidesimt + "devyni";
                    default:
                        return "Įvestas netinkamas skaičius!";
                }

            }
            else if (skaicius >= 30 && skaicius < 40)
            {
                string trisdesimt = "trisdešimt ";
                switch (skaicius)
                {
                    case 30:
                        return minus + " trisdešimt";
                    case 31:
                        return minus + trisdesimt + "vienas";
                    case 32:
                        return minus + trisdesimt + "du";
                    case 33:
                        return minus + trisdesimt + "trys";
                    case 34:
                        return minus + trisdesimt + "keturi";
                    case 35:
                        return minus + trisdesimt + "penki";
                    case 36:
                        return minus + trisdesimt + "šeši";
                    case 37:
                        return minus + trisdesimt + "septyni";
                    case 38:
                        return minus + trisdesimt + "aštuoni";
                    case 39:
                        return minus + trisdesimt + "devyni";
                    default:
                        return "Įvestas netinkamas skaičius!";
                }

            }
            else if (skaicius >= 40 && skaicius < 50)
            {
                string keturiasdesimt = "keturiasdešimt ";
                switch (skaicius)
                {
                    case 40:
                        return minus + " keturiasdešimt";
                    case 41:
                        return minus + keturiasdesimt + "vienas";
                    case 42:
                        return minus + keturiasdesimt + "du";
                    case 43:
                        return minus + keturiasdesimt + "trys";
                    case 44:
                        return minus + keturiasdesimt + "keturi";
                    case 45:
                        return minus + keturiasdesimt + "penki";
                    case 46:
                        return minus + keturiasdesimt + "šeši";
                    case 47:
                        return minus + keturiasdesimt + "septyni";
                    case 48:
                        return minus + keturiasdesimt + "aštuoni";
                    case 49:
                        return minus + keturiasdesimt + "devyni";
                    default:
                        return "Įvestas netinkamas skaičius!";
                }

            }
            else if (skaicius >= 50 && skaicius < 60)
            {
                string penkiasdesimt = "penkiasdešimt ";
                switch (skaicius)
                {
                    case 50:
                        return minus + " penkiasdešimt";
                    case 51:
                        return minus + penkiasdesimt + "vienas";
                    case 52:
                        return minus + penkiasdesimt + "du";
                    case 53:
                        return minus + penkiasdesimt + "trys";
                    case 54:
                        return minus + penkiasdesimt + "keturi";
                    case 55:
                        return minus + penkiasdesimt + "penki";
                    case 56:
                        return minus + penkiasdesimt + "šeši";
                    case 57:
                        return minus + penkiasdesimt + "septyni";
                    case 58:
                        return minus + penkiasdesimt + "aštuoni";
                    case 59:
                        return minus + penkiasdesimt + "devyni";
                    default:
                        return "Įvestas netinkamas skaičius!";
                }

            }
            else if (skaicius >= 60 && skaicius < 70)
            {
                string sesiasdesimt = "šešiasdešimt ";
                switch (skaicius)
                {
                    case 60:
                        return minus + " šešiasdešimt";
                    case 61:
                        return minus + sesiasdesimt + "vienas";
                    case 62:
                        return minus + sesiasdesimt + "du";
                    case 63:
                        return minus + sesiasdesimt + "trys";
                    case 64:
                        return minus + sesiasdesimt + "keturi";
                    case 65:
                        return minus + sesiasdesimt + "penki";
                    case 66:
                        return minus + sesiasdesimt + "šeši";
                    case 67:
                        return minus + sesiasdesimt + "septyni";
                    case 68:
                        return minus + sesiasdesimt + "aštuoni";
                    case 69:
                        return minus + sesiasdesimt + "devyni";
                    default:
                        return "Įvestas netinkamas skaičius!";
                }
            }
            else if (skaicius >= 70 && skaicius < 80)
            {
                string septyniasdesimt = "septyniasdešimt ";
                switch (skaicius)
                {
                    case 70:
                        return minus + " septyniasdešimt";
                    case 71:
                        return minus + septyniasdesimt + "vienas";
                    case 72:
                        return minus + septyniasdesimt + "du";
                    case 73:
                        return minus + septyniasdesimt + "trys";
                    case 74:
                        return minus + septyniasdesimt + "keturi";
                    case 75:
                        return minus + septyniasdesimt + "penki";
                    case 76:
                        return minus + septyniasdesimt + "šeši";
                    case 77:
                        return minus + septyniasdesimt + "septyni";
                    case 78:
                        return minus + septyniasdesimt + "aštuoni";
                    case 79:
                        return minus + septyniasdesimt + "devyni";
                    default:
                        return "Įvestas netinkamas skaičius!";
                }
            }
            else if (skaicius >= 80 && skaicius < 90)
            {
                string astuoniasdesimt = "aštuoniasdešimt ";
                switch (skaicius)
                {
                    case 80:
                        return minus + " aštuoniasdešimt";
                    case 81:
                        return minus + astuoniasdesimt + "vienas";
                    case 82:
                        return minus + astuoniasdesimt + "du";
                    case 83:
                        return minus + astuoniasdesimt + "trys";
                    case 84:
                        return minus + astuoniasdesimt + "keturi";
                    case 85:
                        return minus + astuoniasdesimt + "penki";
                    case 86:
                        return minus + astuoniasdesimt + "šeši";
                    case 87:
                        return minus + astuoniasdesimt + "septyni";
                    case 88:
                        return minus + astuoniasdesimt + "aštuoni";
                    case 89:
                        return minus + astuoniasdesimt + "devyni";
                    default:
                        return "Įvestas netinkamas skaičius!";
                }
            }
            else if (skaicius >= 90 && skaicius < 100)
            {
                string devyniasdesimt = "devyniasdešimt ";
                switch (skaicius)
                {
                    case 90:
                        return minus + " devyniasdešimt";
                    case 91:
                        return minus + devyniasdesimt + "vienas";
                    case 92:
                        return minus + devyniasdesimt + "du";
                    case 93:
                        return minus + devyniasdesimt + "trys";
                    case 94:
                        return minus + devyniasdesimt + "keturi";
                    case 95:
                        return minus + devyniasdesimt + "penki";
                    case 96:
                        return minus + devyniasdesimt + "šeši";
                    case 97:
                        return minus + devyniasdesimt + "septyni";
                    case 98:
                        return minus + devyniasdesimt + "aštuoni";
                    case 99:
                        return minus + devyniasdesimt + "devyni";
                    default:
                        return "Įvestas netinkamas skaičius!";
                }
            }
            else
            {
                return "Not implemented!";
            }


        }


    }
}
