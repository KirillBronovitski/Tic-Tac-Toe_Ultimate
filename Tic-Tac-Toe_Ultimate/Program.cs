namespace Tic_Tac_Toe_Ultimate;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(
            "Hello! Welcome to Tic-Tac-Toe Ultimate! Please enter the length and the width of your playing field.");
        Console.Write("Length --> ");
        int l = Convert.ToInt32(Console.ReadLine()); //getting the length of the field.
        Console.Write("Width --> ");
        int w = Convert.ToInt32(Console.ReadLine()); //getting the width of the field
        Console.WriteLine();
        char[,] table = new char[w, l]; //creating a variable for expressing all symbols made by players (O or X).
        bool counter = false;
        while (true) //loop for changing between players: first player X, then player O and so on
        {
            if (counter == true)
            {
                counter = false;
                boardPrinting(w, l, tableFilling(counter), counter, table);
            }
            else
            {
                counter = true;
                boardPrinting(w, l, tableFilling(counter), counter, table);
            }
        }
    }

    static void
        boardPrinting(int width, int length, char symbol, bool switchingPlayers,
            char[,] table) //function for printing current table with steps made by players.
    {
        Console.Write("  ");
        for (int i = 0; i < length; i++)
        {
            Console.Write("----");
        }

        Console.WriteLine("-");
        for (int y = 0; y < width; y++)
        {
            Console.Write(width - y + " ");
            Console.Write("|");
            for (int x = 0; x < length; x++)
            {
                if (table[length - x - 1, width - y - 1] == 'X' || table[length - x - 1, width - y - 1] == 'O')
                {
                    Console.Write(" " + table[length - x - 1, width - y - 1] + " |");
                }
                else
                {
                    Console.Write("   |");
                }
            }

            Console.WriteLine();
            if (y == width - 1)
            {
                break;
            }

            Console.Write("  |");
            for (int i = 0; i < length; i++)
            {
                Console.Write("---");
            }

            for (int i = 1; i < length; i++)
            {
                Console.Write("-");
            }

            Console.Write("|");
            Console.WriteLine();
        }

        Console.Write("  ");
        for (int i = 0; i < length; i++)
        {
            Console.Write("----");
        }

        Console.WriteLine("-");
        Console.Write("    " + 1);
        for (int i = 2; i < length; i++)
        {
            Console.Write("   " + i);
        }

        Console.WriteLine("   " + length);
        Console.WriteLine();
        Console.WriteLine(playerTurn(switchingPlayers));
        table[CoordinatesInputX(length), CoordinatesInputY(width)] = symbol;
        Console.WriteLine();
    }

    static char tableFilling(bool player1Turn) //function for filling the table with steps made by players 
    {
        char sign;
        switch (player1Turn)
        {
            case true:
                sign = 'X';
                return sign;

            case false:
                sign = 'O';
                return sign;
        }
    }

    static int
        CoordinatesInputX(
            int validInputL) //function for getting x coordinate as input and then returning the value when it is needed 
    {
        while (true)
        {
            Console.Write("x coordinate --> ");
            int xCoordinate = Convert.ToInt32(Console.ReadLine()) - 1; //player's x coordinate
            if (xCoordinate < 0 || xCoordinate > validInputL)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                return xCoordinate;
            }
        }
    }

    static int
        CoordinatesInputY(
            int validInputW) //function for getting y coordinate as input and then returning the value when it is needed 
    {
        while (true)
        {
            Console.Write("y coordinate --> ");
            int yCoordinate = Convert.ToInt32(Console.ReadLine()) - 1; //player's y coordinate
            if (yCoordinate < 0 || yCoordinate > validInputW)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                return yCoordinate;
            }
        }
    }

    static string playerTurn(bool player1Turn) //function for assigning appropirate symbol to player, either X or O 
    {
        string turn;
        switch (player1Turn)
        {
            case true:
                turn = "player X turn:";
                return turn;

            case false:
                turn = "player O turn:";
                return turn;
        }
    }
}