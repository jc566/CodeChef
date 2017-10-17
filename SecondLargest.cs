using System;
using System.Collections.Generic;


class SecondLargest
{
    static void Main(string[] args)
    {
        int largest = 0;
        int secondLargest = 0;
        List<int> listOfSeconds = new List<int>();

        int numOfTest = int.Parse(Console.ReadLine());
        int[,] numsABC = new int[numOfTest, 3];

        for (int i = 0; i < numOfTest; i++)
        {
            string[] userInput = Console.ReadLine().Split(' ');

            for (int j = 0; j < 3; j++)
            {
                numsABC[i, j] = Int32.Parse(userInput[j]);
                
                if(numsABC[i,j] > largest)
                {

                    secondLargest = largest;
                    largest = numsABC[i, j];
                    
                }
                else if(numsABC[i,j] > secondLargest)
                {
                    secondLargest = numsABC[i, j];
                }
            }
            listOfSeconds.Add(secondLargest);
            
            largest = 0;
            
        }


        foreach (int x in listOfSeconds)
        {
            Console.WriteLine(x);
        }



    }
}


