using System.Text.Json;

namespace Minibibliotek_avancerad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInterface userInterface = new UserInterface();
            userInterface.PrintStartMenu();
        }
    }
}
