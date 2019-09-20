|Reid Eastin|
| :---      |
|s198012|
| Mock assessment |
|Number guesing game ducumentation|

## 1. Requirements

1. Description of Problem
- **Name**: Number guesing game

- **Problem Statement**:
Create a number guesing game

- **Problem specifications**: It must be able to eventualy guess the users number or say if the player is cheating and it must be in a loop

2. Input Information
- The 1, 2, and 3 keys are used to tell the game the option you picked

3.  Output Information
The game will show a new number that is bigger or smaller depending on which option you pick. if you say it is your number




## II. Design

1. _System Architecture_


The game starts by asking the player a number between 1 and 20
and waits for the player to press a key.
Once the player presses a key
the game enters a loop untill until the game says the player is cheating or untill the player says it is their number
The player tells the game if it is their number or if ther number is higher or lower



3. ### Object Information

Name: guess
this is a int used to tell player how many guess it takes for the game to find out the number

Name: Computerchoice

this is a int used for the computers guess

Name: maxnumber

this is used for for the game to know what the max number is. the max number is 1 less than what this int is.

Name: minnumber
this is used to set the lowest number the computer can guess

Name: validchoice

a bool used to tell game when to end the loop

Name:choice

the string is used so the game knows what number you typed in

Name: validchoice
bool usede to tell game if the choice is valid
