using System;

namespace MyDictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> countries = new MyDictionary<string, string>();

            countries.Add("Nairobi", "Kenya");
            countries.Add("Helsinki", "Finland");
            countries.Add("Moscow", "Russia");
            countries.Add("Tokyo", "Japan");
            countries.Add("Berlin", "Germany");
            //Con cariño al profesor. :)

            

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("* Countries and Capitals Dictionary Simulation*");
            Selection();



            void Selection()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nSelect an Action \nAdd (a/A) -- Delete (d/D) -- Listing (l/L)");
                var pressed = Console.ReadLine();
                switch (pressed)
                {
                    case "a":
                    case "A":
                        {
                            Console.Clear();
                            Added();
                            Selection();
                            break;
                        }

                    case "d":
                    case "D":
                        {
                            Console.Clear();
                            Listing();
                            Delete();
                            Selection();
                            break;
                        }

                    case "l":
                    case "L":
                        {
                            Console.Clear();
                            Listing();
                            Selection();
                            break;
                        }
                    default:
                        Environment.Exit(0);
                        break;
                }

                
            }

            void Listing()
            {
                for (int i = 0; i < countries.Key.Length; i++)
                {
                    Console.WriteLine(i + "      " + countries.Key.GetValue(i) + " - " + countries.Value.GetValue(i));
                }

                Console.WriteLine("");
            }

            void Added()
            {
                Console.WriteLine("Capital Name: ");
                string capital = Console.ReadLine();
                Console.WriteLine("Country Name: ");
                string country = Console.ReadLine();
                countries.Add(capital, country);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nSuccessfully added: " + capital + " - " + country);
                Console.WriteLine("");
            }

            void Delete()
            {
                Console.WriteLine("Enter index no to delete: ");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nDeleted : " + countries.Key.GetValue(index) + "  " + countries.Value.GetValue(index));
                Array.Clear(countries.Key, index, 1);
                Array.Clear(countries.Value, index, 1);
            }
        } 
    }
}
