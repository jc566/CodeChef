'''
From Codechef link = https://www.codechef.com/problems/TEST

Your program is to use the brute-force approach in order to find the Answer to Life, the Universe, and Everything. More precisely... rewrite small numbers from input to output. Stop processing input after reading in the number 42. All numbers at input are integers of one or two digits.
Example


Input:
1
2
88
42
99

Output:
1
2
88

'''
myArray = [] #initialize an array to be populated

userInput = int(input('Enter any number less than 42')) #prompt

while (userInput < 42) : #do-while equiv
    myArray.append(userInput) #add user input into array
    userInput = int(input('Enter any number less than 42 ')) #allow for more entries

print ("The list of valid numbers entered before breaking is/are : ")
for value in myArray: #display each element one by one
    print(value)