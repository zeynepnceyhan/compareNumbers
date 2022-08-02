namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
             
            int number1, number2;
            Console.WriteLine("Enter the first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine("number1 is greater than number2... ");
            }
            else if (number1 == number2)
            {
                Console.WriteLine("number1 and number2 are equals...");
            }
            else
            {
                Console.WriteLine("number2 is greater than number1...");
            }




        }

    }

}