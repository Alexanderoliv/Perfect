using System;

public class Perfect
{
    public static bool IsPerfect(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }
        return sum == n;
    }

    public static void DisplayPerfectNumbers()
    {
        for (int i = 1; i <= 10000; i++)
        {
            if (IsPerfect(i))
            {
                Console.WriteLine($"{i} is a Perfect Number");
            }
        }
    }
}

public class UnitTest
{
    public static void RunTests()
    {
        Test(496, true, "Test #1");
        Test(68, false, "Test #2");
        Test(5112, false, "Test #3");
        Test(8128, true, "Test #4");
    }

    public static void Test(int number, bool expectedOutcome, string testName)
    {
        bool result = Perfect.IsPerfect(number);
        if (result == expectedOutcome)
        {
            Console.WriteLine($"{testName}: Passed");
        }
        else
        {
            Console.WriteLine($"{testName}: Failed");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Perfect Numbers from 1 to 10,000:");
        Perfect.DisplayPerfectNumbers();

        Console.WriteLine("\nRunning Unit Tests:\n");
        UnitTest.RunTests();
    }
}
