'''
CodeChef Link = https://www.codechef.com/problems/FSQRT
In olden days finding square roots seemed to be difficult but nowadays it can be easily done using in-built functions available across many languages .

Assume that you happen to hear the above words and you want to give a try in finding the square root of any given integer using in-built functions. So here's your chance.
Input

The first line of the input contains an integer T, the number of test cases. T lines follow. Each T contains an integer N whose square root needs to be computed.
Output

For each line of input output the square root of the input integer.
Constraints

1<=T<=20
1<=N<=10000

Input:
3
10
5
10000

Output:
3
2
100

'''
import math

intT = int(input("how many test cases?"))

aList = []

for cases in range(intT):
    intN = int(input("enter a number to be square rooted"))

    result = int(math.sqrt(intN))

    aList.append(result)

for display in range(intT):
    print(aList[display])


print(aList)
