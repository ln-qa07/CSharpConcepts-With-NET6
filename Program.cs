using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //add();

        //Swap();

        //sizeoff();

        //operatorsvalue();

        //IdentiyNumberIsEven();

        //IdentiyMaximumOfThreeNumbers();

        //IdentifyMaximumNumberUsingIdentical();

        IdentifyLeapYear();

    }

    private static void add()
    {
        Console.WriteLine("Please enter the number 1:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the number 2:");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The addition of the numbers is " + Convert.ToString(x + y));      
    }
    private static void Swap()
    {
        Console.Write("Please enter the number x:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter the number y:");
        int y = Convert.ToInt32(Console.ReadLine());

        x = x + y;
        y = x - y;
        x = x - y;

        Console.WriteLine("Value of x:"+x);

        Console.WriteLine("Value of y:"+y);
    }
    private static void sizeoff()
    {
        Console.WriteLine("Size of int: " + sizeof(int));

        Console.WriteLine("Size of char: " + sizeof(char));
    }
    private static void operatorsvalue()
    {
        int value1 = 365;
        int value2 = 367;

        Console.WriteLine(value2 / value1);

        Console.WriteLine(value2 % value1);
    }
    private static void IdentiyNumberIsEven()
    {
        Console.WriteLine("Enter the value :");
        var value = Console.Read();

        if (value % 2 == 0)
            Console.WriteLine("Given value is even");
        else
            Console.WriteLine("Given value is odd");
    }
    private static void IdentifyMaximumOfThreeNumbers()
    {
        int num1, num2, num3;

        Console.Write("Enter number 1:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number 2:");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number 3:");
        num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
            if (num1 > num3)
                Console.WriteLine(num1 + " is greater than all");
            else
                Console.WriteLine(num3 + " is greater than all");
        else if (num2 > num3)
            Console.WriteLine(num2 + " is greater than all");
        else
            Console.WriteLine(num3 + " is greater than all");

    }
    private static void IdentifyMaximumNumberUsingIdentical()
    {
        //int value = 65 > 76 ? 70 : 45;
        //Console.Write(value); Value will be 45

        int num1, num2, num3, largest;

        Console.Write("Enter number 1:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number 2:");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number 3:");
        num3 = Convert.ToInt32(Console.ReadLine());

        largest = num1 > num2 ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);

        Console.WriteLine(largest);


    }
    private static void IdentifyLeapYear()
    {
        int year;
        Console.Write("Enter the year :");

        year = Console.Read();

        Console.WriteLine(year % 4 == 0 ? "It is the Leap year" : "It is not the leap year");
    }
}