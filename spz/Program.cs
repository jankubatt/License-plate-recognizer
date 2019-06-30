using System;

namespace spz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SPZ Recognizer";


            while (true)
            {
                Console.Write("Zadej SPZ: ");
                bool spz = true;
                string vstup = Console.ReadLine();

                if (vstup.Length < 8 || vstup.Length > 8)
                {
                    Console.WriteLine("Nekorektní vstup");
                    spz = false;
                }
                else
                {
                    spz = true;
                    vstup = vstup.Remove(2);
                    vstup = vstup.Remove(0, 1);
                    vstup = vstup.ToUpper();
                }

                while (spz)
                {
                    switch (vstup)
                    {
                        case "A":
                            Console.WriteLine("Hlavní město Praha");
                            break;

                        case "B":
                            Console.WriteLine("Jihomoravský kraj");
                            break;

                        case "C":
                            Console.WriteLine("Jihočeský kraj");
                            break;

                        case "E":
                            Console.WriteLine("Pardubický kraj");
                            break;

                        case "H":
                            Console.WriteLine("Královehradecký kraj");
                            break;

                        case "J":
                            Console.WriteLine("Kraj Vysočina");
                            break;

                        case "K":
                            Console.WriteLine("Karlovarský kraj");
                            break;

                        case "L":
                            Console.WriteLine("Liberecký kraj");
                            break;

                        case "M":
                            Console.WriteLine("Olomoucký kraj");
                            break;

                        case "P":
                            Console.WriteLine("Plzeňský kraj");
                            break;

                        case "S":
                            Console.WriteLine("Středočeský kraj");
                            break;

                        case "T":
                            Console.WriteLine("Moravskoslezský kraj");
                            break;

                        case "U":
                            Console.WriteLine("Ústecký kraj");
                            break;

                        case "Z":
                            Console.WriteLine("Zlínský kraj");
                            break;

                        default:
                            Console.WriteLine("Nekorektní vstup, nebo kraj neexistuje, nebo se jedná o vlastní SPZ");
                            break;
                    }
                    break;
                }               
            }
        }
    }
}
