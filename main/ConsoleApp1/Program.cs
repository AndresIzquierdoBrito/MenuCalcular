using System.Runtime.InteropServices;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        int userInput;
        do
        {
            Console.WriteLine("Introduce un numero para elegir en el menu: ");
            Console.Write("No: ");
            userInput = Convert.ToInt32(Console.ReadLine());
        }while(userInput == null);
        
        if(userInput == 1)
            Console.WriteLine("Bien, uno.");
        if(userInput == 2)
            Console.WriteLine("Bien, dos.");
        if(userInput == 3)
            Console.WriteLine("Bien, tres.");
        if(userInput == 4)
            Console.WriteLine("Bien, cuatro.");
        if(userInput == 5)
            Console.WriteLine("Bien, cinco.");
    }
}