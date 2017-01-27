'''
Shivam is the youngest programmer in the world, he is just 12 years old.
Shivam is learning programming and today he is writing his first program.
Program is very simple, Given two integers A and B, write a program to add these two numbers.

Input

The first line contains an integer T, total number of test cases.
Then follow T lines, each line contains two Integers A and B.

Output

Add A and B and display it.

Constraints

1 <= T <= 1000
1 <= A,B <= 10000

Example

Input
3 
1 2
100 200
10 40

Output
3
300
50



'''

numOfCases = int(input('How many test cases?'))
while (numOfCases < 1 or numOfCases > 1000):
    numOfCases = int(input('Invalid! Case Test Number must be between 1 & 1000'))

for case in range(numOfCases) :
    value01 = int(input('Enter First Num'))
    while (value01 < 1 or value01 > 10000):
        value01 = int(input('Enter First Num Again, Last Input Was INVALID. Your Num MUST Be Between 1 & 10000'))
    value02 = int(input('Enter Second Num'))
    while (value02 < 1 or value02 > 10000):
        value02 = int(input('Enter Second Num Again,  Last Input Was INVALID. Your Num MUST Be Between 1 & 10000'))
    total = value01 + value02
    print("The sum of numbers given is " + str(total))
