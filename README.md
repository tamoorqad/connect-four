# connect-four

Connect Four - OOP Term Project  
Object-Oriented Programming  
Student: Tamoor Qadeer

## Project Description
A console-based Connect Four game built using Object-Oriented Programming principles in C#.

## How to Play
- Two players take turns entering a column number (1-7)
- First player to get 4 in a row wins
- Supports horizontal, vertical, and diagonal wins

## OOP Structure
- **Board** - manages the 6x7 grid, piece placement, and win/draw detection
- **Player** - abstract base class with name and symbol
- **HumanPlayer** - inherits from Player, gets move from console input
- **GameController** - runs the game loop and manages turns
- **GameView** - handles all console output
