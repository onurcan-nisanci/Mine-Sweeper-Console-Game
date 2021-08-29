# About
Inspired by Minesweeper game and implemented its basic rules in a console application way. 

Example input (a 3 x 4 mine-field of 12 squares, 2 of
which are mines)

```
3 4
*...
..*.
....
```

Your purpose here is to write a program to accept this input and
produce as output a hint-field of identical dimensions.

**Rules of the game:**

* In the example above, **3** indicates count of the total rows, **4** indicates count of the total columns.
* The character '*' represents
a mine and the character '.' represents no-mine.

To find out whether there is a mine or not, we'll check it out: **left, right, top, bottom, top-left, top-right, bottom-left and bottom right** positions for each dots '.'
for mines '*', we'll just pass it over to output.
 
Example output (for the above input)
```
*211
12*1
0111
```
![Mine_Sweeper_Console01](https://user-images.githubusercontent.com/39779689/131257759-c6239f76-7f6b-42b2-8591-2f37e4ca5b72.png)

# Getting Started

* Be sure at least you have .NET 5.0 version installed in your computer.
* Run your Visual Studio IDE (which is compatible with .NET 5 and up versions).
* You're good to go!

# MIT License

Copyright (C) 2021 Onur Can Nisanci

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
