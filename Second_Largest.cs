/* link to codechef problem = https://www.codechef.com/problems/FLOW017
 *  Three numbers A, B and C are the inputs. Write a program to find second largest among three numbers.
Input

The first line contains an integer T, total number of testcases. Then follow T lines, each line contains three integers A, B and C.
Output

Display the second largest among A, B and C.
Constraints

    1 ≤ T ≤ 1000
    1 ≤ A,B,C ≤ 1000000

Example

Input
3 
120 11 400
10213 312 10
10 3 450

Output

120
312
10
*/
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> listOfSeconds = new List<int>();
        int largest = 0;
        int secondLargest = 0;

        
            

        int numOfTest = int.Parse(Console.ReadLine());

        int[,] numsABC = new int[numOfTest, 3];

        for(int i = 0; i < numOfTest; i++)
        {
            string[] userInput = Console.ReadLine().Split(' ');

            for(int j = 0; j < 3; j++)
            {
                numsABC[i, j] = int.Parse(userInput[j]);

                if(numsABC[i,j] > largest)
                {
                    secondLargest = largest;
                    largest = numsABC[i, j];
                }
                else if (numsABC[i,j] > secondLargest)
                {
                    secondLargest = numsABC[i, j];
                }
            }
            listOfSeconds.Add(secondLargest);

            largest = 0;
        }

        foreach(int x in listOfSeconds)
        {
            Console.WriteLine(x);
        }


    }
}

