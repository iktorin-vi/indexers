//Done: Viktoria Kaznienko 
//Group:3
//Variant:7

using System;
using Class;
class Program
{
    static void Main()
    {
        int[,] arr = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
            };
        Matrix m = new Matrix(arr);
        Console.WriteLine("Sum of values of the third column:" + m[2]);//сума всіх значень третьої колонки.
        Console.WriteLine("Root mean square: " + m.Rmeansquare);
    }

}