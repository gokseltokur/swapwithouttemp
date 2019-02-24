using System;

class Solution
{
    public static void Main(string[] args)
    {
        int x, y;
        Console.WriteLine("Enter the value of x");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the value of y");
        y = Convert.ToInt32(Console.ReadLine());

        x = x + y;
        y = x - y;
        x = x - y;

        Console.Write("New values are : \n x = " + x + "\n y = " + y);
    }
}