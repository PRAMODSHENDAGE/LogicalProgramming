using LogicalPrograms;
Console.WriteLine("Welcome to Logical Programming");
while (true)
{
    Console.WriteLine("Select program\n 1. fibonacci series");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            FibonacciSeries.Fibonacci();
            break;
        default:
            Console.WriteLine("Select correct option");
            break;
    }
}
