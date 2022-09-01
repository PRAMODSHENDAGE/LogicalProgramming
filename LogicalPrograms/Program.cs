using LogicalPrograms;
Console.WriteLine("Welcome to Logical Programming");
while (true)
{
    Console.WriteLine("Select program\n 1. fibonacci series\n 2. Perfect Number\n 3. Prime Number\n 4. Reverse Number\n 5. Temperature Conversion\n 6. Coupon Numbers\n 7. Day Of Week");
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
        case 5:
            TemperatureConversion temperatureconversion = new TemperatureConversion();
            temperatureconversion.Temperatureconversion();
            break;
        case 6:
            CouponNumbers couponNumbers = new CouponNumbers();
            couponNumbers.DistinctCouponNumber();
            break;
        case 7:
            WeekDay weekday = new WeekDay();
            weekday.Days();
            break;
        default:
            Console.WriteLine("Select correct option");
            break;
    }
}
