namespace project_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int firstnumber, secondnumber, i, j;

            Console.WriteLine("Enter starting number of range");
            firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ending number of range");
            secondnumber = int.Parse(Console.ReadLine());
            int count = 0;
            Console.WriteLine("the prime numbers between {0} and {1} is ", firstnumber, secondnumber);
            for (i = firstnumber; i <= secondnumber; i++)
            {
                for (j = 2; j <= secondnumber; j++)
                {
                    if (i % j == 0)
                        count++;

                }
                if (count == 1)
                {

                    Console.WriteLine(i);
                }
                count = 0;
            }


        }
    }
}