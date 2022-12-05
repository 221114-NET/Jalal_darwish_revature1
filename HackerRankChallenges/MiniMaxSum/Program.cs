﻿namespace MiniMaxSum;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Please enter 5 integers, separated by a single space");

        //Taken from Hackerrank challenge. Takes console input, splits by 'space' character, puts into list, transforms it into a list of integers and returns that
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        MiniMaxSum.miniMaxSum(arr);
    }
}

class MiniMaxSum
{
    /// <summary>
    /// Method that gets the minimum and maximum sum of a list of 5 integers
    /// </summary>
    /// <param name="intList">List of 5 integers</param>
    public static void miniMaxSum(List<int> intList)
    {
        //Converts list into array
        int[] intArray = intList.ToArray();
        //Sorts the array
        Array.Sort(intArray);
        //Declaring min and max sum to store running totals
        long minSum = 0, maxSum =0;
        //Loop to iterate through array and total up the sums. Index i for lower 4, j for upper 4 numbers
        for(int i=0 , j=1; j<intArray.Length; ++i, ++j)
        {
            minSum += intArray[i];//Sum together first 4 numbers
            maxSum += intArray[j];//Sum together last 4 numbers
        }
        //Print to console min followed by max
        System.Console.WriteLine(minSum + " " + maxSum);
    }
}