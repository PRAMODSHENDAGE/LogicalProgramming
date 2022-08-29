using LogicalPrograms;
Console.WriteLine("Welcome to Logical Programming");
while (true)
{
    Console.WriteLine("Select program\n 1. fibonacci series\n 2. Perfect Number\n 3. Prime Number\n 4. Reverse Number");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            FibonacciSeries.Fibonacci();
            break;
        case 2:
            PerfectNumber.Perfectnumber();
            break;
        case 3:
            PrimeNumber.Primenumber();
            break;
        case 4:
            ReverseNumber.ReverseANumber();
            break;
        default:
            Console.WriteLine("Select correct option");
            break;
    }
}
