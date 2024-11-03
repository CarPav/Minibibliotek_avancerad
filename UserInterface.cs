using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Minibibliotek_avancerad
{
    public class UserInterface
    {
        public Library Library = new Library();
        public List<Book> allBooks = new List<Book>();
        string dataJSONfilPath = "LibraryData.json";

        public void PrintStartMenu()
        {
            Console.WriteLine("--- Välkommen till MINI-BIBBLAN ---");
            while (true)
            {
                Console.WriteLine("\n----  STARTMENY  ----");
                Console.WriteLine("\n1. Lägg till en ny bok");
                Console.WriteLine("2. Lägg till en ny författare");
                Console.WriteLine("3. Uppdatera bokdetaljer");
                Console.WriteLine("4. Uppdatera författardetaljer");
                Console.WriteLine("5. Ta bort en bok");
                Console.WriteLine("6. Ta bort en författare");
                Console.WriteLine("7. Visa alla böcker och författare");
                Console.WriteLine("8. Sök och filtrera böcker");
                Console.WriteLine("9. Avsluta och spara ändringar");
                Console.Write("\nAnge ditt val: ");
                string userOption = Console.ReadLine()!;
                Console.Clear();

                switch (userOption)
                {
                    case "1":
                        Console.WriteLine("1. Lägg till en ny bok");
                        Library.AddNewBook(allBooks);
                        break;
                    case "2":
                        Console.WriteLine("2. Lägg till en ny författare");
                        Library.AddNewAuthor();
                        break;
                    case "3":
                        Console.WriteLine("3. Uppdatera bokdetaljer");
                        Library.UpdateBook();
                        break;
                    case "4":
                        Console.WriteLine("4. Uppdatera författardetaljer");
                        Library.UpdateAuthor();
                        break;
                    case "5":
                        Console.WriteLine("5. Ta bort en bok");
                        Library.RemoveBook();
                        break;
                    case "6":
                        Console.WriteLine("6. Ta bort en författare");
                        Library.RemoveAuthor();
                        break;
                    case "7":
                        Console.WriteLine("7. Visa alla böcker och författare");
                        Library.ListAllBooksAndAuthors(allBooks);
                        break;
                    case "8":
                        Console.WriteLine("8. Sök och filtrera böcker");
                        Library.SearchAndFilterBooks();
                        break;
                    case "9":
                        Console.WriteLine("Tack för du använde Minibibblan, välkommen åter!");
                        string updateDatabaseWithBook = JsonSerializer.Serialize(allBooks, new JsonSerializerOptions { WriteIndented = true });
                        File.WriteAllText(dataJSONfilPath, updateDatabaseWithBook);
                        return;
                    default:
                        Console.WriteLine("Ogiltligt val, försök igen");
                        break;
                }
            }
        }

    }
}
