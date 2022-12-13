internal class Program
{
    private static void Main(string[] args)
    {
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
    }
}