using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class arrsampl/////This C# Program, we are creating the object variable ‘obj’ for arrsampl class. The printarray() function is used to enter the coefficient element values of the array using a[i,j] variable.///
{
    int[,] x;
    arrsampl()
    {
        x = new int[,] { { 11, 2, 61 }, { 42, 50, 3 } };///The max() method is used to find the smallest element in a matrix. For loop is used to check each element values in the array. If else condition statement is used to check the value of ‘small’ variable is greater than the value of ‘x[i,j]’ variable.////
    }
    void printarray()
    {
        Console.WriteLine("Elements in the Given Matrix : ");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(x[i, j] + "\t");
            }
            Console.WriteLine("\n");
        }
    }
    int max()////If the condition is true, then execute the statement and assign the value of ‘x[i,j]’ variable to small variable. Print the smallest element in a matrix.//
    {
        int small = x[0, 0];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (small > x[i, j])
                {
                    small = x[i, j];
                }
            }
        }
        return small;
    }
    public static void Main()
    {
        arrsampl obj = new arrsampl();
        obj.printarray();
        Console.WriteLine("Smallest Element : {0}", obj.max());
        Console.ReadLine();
    }
}
///Output:Elements in the Given Matrix :
///11  2  61
///42  50  3
///Smallest Element : 2