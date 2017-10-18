'''
Your program is to use the brute-force approach in order to find the Answer to Life, the Universe, and Everything. More precisely... 
rewrite small numbers from input to output. Stop processing input after reading in the number 42. All numbers at input are integers of one or two digits.
'''


myArray = []

userInput = int(input('Enter any number less than 42'))

while(userInput != 42):
    myArray.append(userInput)
    userInput = int(input('Enter any number lss than 42'))

for value in myArray:
    print(value)

