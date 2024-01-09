namespace benzersiz_random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("starting number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("ending number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("how many numbers do you want to sort ?");
            byte count = byte.Parse(Console.ReadLine());



            int[] numbers = new int[count];
            Random rnd = new Random();
            int c;
            for (int i = 0; i < count; i++)
            {
                c = rnd.Next(a, b);
                if (i == 0)
                {
                    numbers[i] = c;
                }
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] == c)
                    {
                        i--;
                        break;
                    }
                    else
                    {
                        numbers[i] = c;
                    }
                }
            }


            Array.Sort(numbers);
            Console.WriteLine("Sorted Numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
