using System;

namespace SnapchatInterviewQuestion
{
    //Given an array of time intervals (start, end) for classroom lectures
    //(possible overlapping), find the minimum number of rooms required.
    // ie: [(30,75),(0,50),(60,150)]
    // output : 2
    class Program
    {
        static void Main(string[] args)
        {
            int[] start = { 30, 0, 60 };
            int[] end = { 75, 50, 150 };
            int counter = MinNumClasses(start, end);
            Console.WriteLine($"You need a minimum of {counter} rooms");
        }

        private static int MinNumClasses(int[] start, int[] end)
        {
            
            int OverlappingRooms = 0;
            for (int i = 0; i < start.Length; i++)
            {
                int counter = 1;
                for (int  j = 0;  j < start.Length ;  j++)
                {
                    if(end[i] >= start[j] && end[i] <= end[j])
                    {
                        if(i==j)
                        {
                            continue;
                        }
                        else
                        {
                            counter++;
                        }
                    }
                }
                if( counter > OverlappingRooms )
                {
                    OverlappingRooms = counter;
                }
            }
            return OverlappingRooms;
        }
    }
}
