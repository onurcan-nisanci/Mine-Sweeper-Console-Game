using System;
using System.Collections.Generic;

namespace MineSweeperGame
{
    //# Mine Sweeper code writing exercise

    // A field of N x M squares is represented by N lines of
    // exactly M characters each.The character '*' represents
    // a mine and the character '.' represents no-mine.

    // Example input(a 3 x 4 mine-field of 12 squares, 2 of
    // which are mines)

    //3 4
    //*...
    //..*.
    //....

    // Your task is to write a program to accept this input and
    // produce as output a hint-field of identical dimensions
    // where each square is a* for a mine or the number of
    // adjacent mine-squares if the square does not contain a mine.

    //Example output(for the above input)
    //*211
    //12*1
    //0111

    class Program
    {
        #region Fields
        static int _rowCount;
        static int _columnCount;
        static List<string> _inputValues;
        static List<string> _outputValues;
        #endregion

        static void Main(string[] args)
        {
            ApplyColumnsAndRows();
        }

        static void ApplyColumnsAndRows()
        {
            _inputValues = new List<string>();

            Console.WriteLine("Please, do enter rows and columns e.g 3 4");
            Console.Write("> ");

            string input = Console.ReadLine();
            string[] values = input.Trim().Split(" ");

            if (values.Length < 2)
            {
                ApplyColumnsAndRows();
                return;
            }

            _rowCount = Convert.ToInt32(values[0]);
            _columnCount = Convert.ToInt32(values[1]);

            for (int i = 0; i < _rowCount; i++)
            {
                string inputVal = Console.ReadLine();

                // If input's size isn't matching with defined one then complete it
                if(inputVal.Length < _columnCount)
                {
                    for (int j = inputVal.Length; j <= _columnCount; j++)
                    {
                        inputVal += '.';
                    }
                }
                string fixedVal = inputVal.Substring(0, _columnCount);
                _inputValues.Add(fixedVal);
            }

            Console.WriteLine("\n>Here are the results: ");
            Console.WriteLine(CreateOutput());

            Console.WriteLine("Would you like to play another round? Enter Y or N.");
            Console.Write("> ");

            string answer = Console.ReadLine();

            if (answer.ToUpper().Equals("Y"))
                ApplyColumnsAndRows();
        }

        static string CreateOutput()
        {
            string gameOutput = "\n";
            _outputValues = new List<string>();

            int currRowIndex = 0;

            foreach (string currRow in _inputValues)
            {
                string curRowValue = string.Empty;

                for (int i = 0; i < _columnCount; i++)
                {
                    if (currRow[i] == '*')
                    {
                        curRowValue += '*';
                        continue;
                    }
                    curRowValue += GetMinesNearby(currRowIndex, i).ToString();
                }
                _outputValues.Add(curRowValue);
                currRowIndex++;
            }

            foreach (string output in _outputValues)
            {
                gameOutput += output + "\n";
            }

            return gameOutput;
        }
        
        static int GetMinesNearby(int curRow, int curColumn)
        {
            int minesCounter = 0;
            int colPosToCheck = 0;
            int rowPosToCheck = 0;

            // 1- Check left
            colPosToCheck = curColumn - 1;

            if (colPosToCheck >= 0)
            {
                if (_inputValues[curRow][colPosToCheck] == '*')
                    minesCounter++;
            }

            // 2- Check right
            colPosToCheck = curColumn + 1;

            if (colPosToCheck < _inputValues[curRow].Length)
            {
                if (_inputValues[curRow][colPosToCheck] == '*')
                    minesCounter++;
            }
            // 3- Check top
            rowPosToCheck = curRow - 1;

            if (rowPosToCheck >= 0)
            {
                if (_inputValues[rowPosToCheck][curColumn] == '*')
                    minesCounter++;
            }

            // 4- Check bottom
            rowPosToCheck = curRow + 1;

            if (rowPosToCheck < _inputValues.Count)
            {
                if (_inputValues[rowPosToCheck][curColumn] == '*')
                    minesCounter++;
            }

            // 5- Check left-top
            rowPosToCheck = curRow - 1;
            colPosToCheck = curColumn - 1;

            if (rowPosToCheck >= 0 && colPosToCheck >= 0)
            {
                if (_inputValues[rowPosToCheck][colPosToCheck] == '*')
                    minesCounter++;
            }

            // 6- Check right-top
            rowPosToCheck = curRow - 1;
            colPosToCheck = curColumn + 1;

            if (rowPosToCheck >= 0 && colPosToCheck < _inputValues[curRow].Length)
            {
                if (_inputValues[rowPosToCheck][colPosToCheck] == '*')
                    minesCounter++;
            }

            // 7- Check right-bottom
            rowPosToCheck = curRow + 1;
            colPosToCheck = curColumn + 1;

            if (rowPosToCheck < _inputValues.Count && colPosToCheck < _inputValues[curRow].Length)
            {
                if (_inputValues[rowPosToCheck][colPosToCheck] == '*')
                    minesCounter++;
            }

            // 8- Check left-bottom
            rowPosToCheck = curRow + 1;
            colPosToCheck = curColumn - 1;

            if (rowPosToCheck < _inputValues.Count && colPosToCheck >= 0)
            {
                if (_inputValues[rowPosToCheck][colPosToCheck] == '*')
                    minesCounter++;
            }

            return minesCounter;
        }
    }
}