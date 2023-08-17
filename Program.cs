namespace PrimeNumberChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? choice = "y";
            do
            {
                Console.Write("Enter the positive integer: ");
                string? userInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("Please type a positive integer!");
                }
                else
                {
                    Console.WriteLine();
                    if (int.TryParse(userInput, out int number))
                    {
                        if (IsPrime(number))
                        {
                            Console.WriteLine($"{number} is a prime number.\n");
                        }
                        else
                        {
                            Console.WriteLine($"{number} is not a prime number.\n");
                        }

                        do
                        {
                            Console.Write("Do you want to check another number? (y/n): ");
                            choice = Console.ReadLine();
                            if (choice == "n")
                            {
                                Console.WriteLine("Goodbye!");
                            }
                            else if (choice != "y")
                            {
                                Console.WriteLine("\nPlease choose between (y/n).");
                            }
                        } while (choice != "y" && choice != "n");
                    }
                }
            } while (choice != "n");
        }

        static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            if (n <= 3)
            {
                return true;
            }
            if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }

            int sqrt = (int)Math.Sqrt(n);
            for (int i = 5; i <= sqrt; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}