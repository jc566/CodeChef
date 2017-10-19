using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;


    class RacingHorses
    {
        static void Main(string[] args)
        {
            //ask to find out the number of test cases 
            int numOfTests = int.Parse(Console.ReadLine());

            //list that will contain the skill differences
            List<int> skillList = new List<int>();

            //list that will contain the value of differences between numbers
            List<int> differences = new List<int>();

            //Start Asking them questions!
            for(int i = 0; i < numOfTests; i++)
            {
                //ask how many horses there are in this test case
                int numOfHorses = int.Parse(Console.ReadLine());

                //ask for the horses skill rating for this current test case
                string[] userInput = Console.ReadLine().Split(' ');

                //store the skills inside the array
                for (int j = 0; j < numOfHorses; j++)
                {
                    //add the split user input into the list as seperate elements
                    skillList.Add(int.Parse(userInput[j]));
                }

                //sort the array of horse skill ratings from smallest to biggest
                skillList.Sort();

                //UnComment this for loop to see what values you are entering
                //for(int j = 0; j < skillList.Count; j++)
                //{
                //    Console.WriteLine("Your list of skill ratings entered is " +j + "'s value is " + skillList[j]);
                //}
            
                /********************************************************************************************************
                 * loop through the amount of horses minus one because we will be using the NEXT element.               *
                 * When the range is numOfHorses, the next element viewing is not possible.                             *
                 * When the range is numOfHorses-1, the next element is viewed and used AND we hit the end of the list! *
                 *******************************************************************************************************/
                for(int j = 0; j < numOfHorses-1; j++)
                {
                    //find the 2nd element and the first element and subtract their values
                    differences.Add(skillList.Skip(1).First() - skillList.First());
                    //remove the first element from the list
                    skillList.RemoveAt(0);
                }

                //UnComment this loop to see all the differences we have
                //for (int j = 0; j < differences.Count; j++)
                //{
                //    Console.WriteLine("Your List of differences is the Following : Element " + j + " valuse is " + differences[j]);
                //}

                //find the lowest number in the list and display it 
                Console.WriteLine(differences.Min());

                //Clear the lists for reuse since we left one element remaining in each list due to the range of numOfHorses-1
                skillList.Clear();
                differences.Clear();
            }
        }
    }

