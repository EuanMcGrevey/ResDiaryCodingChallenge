using System;
using System.Collections.Generic;

using ResDiary; 

public class Program 
{
  public static void Main() 
  {
    // Ideally would use NUnit to properly test, but here's some quick examples

    /// Test case 1
    int[] testArray1 = { 1, 2, 3, 4, 5 }; 
    List<int[]> testResult1 = Utils.groupArrayElements(testArray1, 3); // should result in [[1, 2], [3, 4] , [5]]
    Console.WriteLine(Utils.printableElements(testResult1));

    /// Test case 2
    int[] testArray2 = { 1, 2, 3, 4 };
    List<int[]> testResult2 = Utils.groupArrayElements(testArray2, 3); // should result in [[1] , [2], [3, 4]]
    Console.WriteLine(Utils.printableElements(testResult2));

    /// Test case 3
    int[] testArray3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    List<int[]> testResult3 = Utils.groupArrayElements(testArray3, 5); // should result in [[1, 2, 3, 4, 5], [6, 7, 8, 9, 10]]
    Console.WriteLine(Utils.printableElements(testResult3));

    /// Test case 4
    int[] testArray4 = { };
    List<int[]> testResult4 = Utils.groupArrayElements(testArray4, 2); // should result in []
    Console.WriteLine(Utils.printableElements(testResult4));
  }
}