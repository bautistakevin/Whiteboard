using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookInterviewQuestion
{
    class Program
    {
        //Given n non-negative integers representing an elevation map where the width of each bar is 1, 
        //compute how much water it is able to trap after raining.
        static void Main(string[] args)
        {
            int[] elevationMap1 = { 2, 1, 2 };
            Console.WriteLine($"Water Stored: {CalculateWaterStored(elevationMap1)}");
            int[] elevationMap2 = { 3, 0, 1, 3, 0, 5 };
            Console.WriteLine($"Water Stored: {CalculateWaterStored(elevationMap2)}");
        }

        static int CalculateWaterStored(int[] elevationMap)
        {
            int waterStored = 0;
            int landValue = 0;
            int leftWallIndex = 0;
            for (int i = 1; i < elevationMap.Length; i++)
            {
                if (elevationMap[leftWallIndex] <= elevationMap[i])
                {
                    waterStored += (i - leftWallIndex - 1) * Math.Min(elevationMap[leftWallIndex], elevationMap[i]);
                    waterStored -= landValue;
                    landValue = 0;
                    leftWallIndex = i;
                }
                else
                {
                    landValue += elevationMap[i];
                }
            }
            return waterStored;
        }

        
    }
}
