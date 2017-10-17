'''
CodeChef URL LINK = https://www.codechef.com/problems/FLOW006
You're given an integer N. Write a program to calculate the sum of all the digits of N.
Input
The first line contains an integer T, total number of testcases. Then follow T lines, each line contains an integer N.
Output
Calculate the sum of digits of N.
Constraints
1 <= T <= 1000
1 <= N <= 100000
Example
Input
3 
12345
31203
2123
Output
15
9
8
'''

numOfCases = int(input('how many test cases?'))
while(numOfCases < 1 or numOfCases > 1000):
    numOfCases = input('How many test cases?')

for line in range(numOfCases):
    setOfNumber = input()
    setOfNumber = list(setOfNumber)

    print(sum(map(int,setOfNumber)))
