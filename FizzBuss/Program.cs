// See https://aka.ms/new-console-template for more information

static void FizzBuss1()
{
    for (int i = 1; i <= 100; ++i)
    {
        if (i % 5 == 0 && i % 3 == 0)
            Console.WriteLine("FizzBuzz \n");
        else if (i % 3 == 0)
            Console.WriteLine("Fizz \n");
        else if (i % 5 == 0)
            Console.WriteLine("Buzz \n");
        else
            Console.WriteLine($"{i} \n");
    }
}

static void FizzBuss2()
{
    Enumerable.Range(1, 100)
        .Select(x =>
        {
            var str = "";
            if (x % 5 == 0 && x % 3 == 0)
                str += "FizzBuzz \n";
            else if (x % 3 == 0)
                str += "Fizz \n";
            else if (x % 5 == 0)
                str += "Buzz \n";
            else
                str += $"{x} \n";
            return str;
        })
        .ToList()
        .ForEach(Console.WriteLine);
}

FizzBuss1();
FizzBuss2();