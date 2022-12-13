using System.Runtime.InteropServices;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
<<<<<<< HEAD
        int num, num1, num2 = 0;
        Console.WriteLine("Inserte un numero");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserte un numero");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Meteme un numero papi");
        num = Convert.ToInt32(Console.ReadLine());
        if (num == 1)
            Console.WriteLine(num1 + num2);
        
        if (num == 2)
            Console.WriteLine(num1 - num2);

        if (num == 3)
            Console.WriteLine(num1 * num2);

        if (num == 4)
            Console.WriteLine(num1 / num2);
        Console.ReadKey();
=======
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
>>>>>>> origin/andres
    }
}