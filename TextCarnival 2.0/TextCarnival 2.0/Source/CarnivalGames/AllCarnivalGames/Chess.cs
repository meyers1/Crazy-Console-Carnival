using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class Piece
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int color { get; private set; }
        public virtual bool IsValidMove(int X, int Y, int newX, int newY)
        {
            return false;
        }
    }

    class Pawn : Piece
    {
        public override bool IsValidMove(int X, int Y, int newX, int newY)
        {
            if ()
        }
    }

    class Rook : Piece
    {

    }

    class Knight : Piece
    {

    }

    class Bishop : Piece
    {

    }

    class King : Piece
    {

    }

    class Queen : Piece
    {

    }

    class Chess : CarnivalGame
    {
        static string[,] board = new string[8, 8];

        public Chess() : base()
        {

        }

        public override string getName()
        {
            return "Chess";
        }

        public override void play()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = "   ";
                }
            }
            DrawBoard();
        }

        public void DrawBoard()
        {
            write("       ---------------------------------");
            for (int i = 0; i < 8; i++)
            {
                write("\n    " + (8 - i) + "  !");
                for (int j = 0; j < 8; j++)
                {
                    write(board[i, j] + "!");
                }
                if (i == 7)
                {
                    writeLine("\n       ---------------------------------");
                }
                else
                {
                    write("\n       !---+---+---+---+---+---+---+---!");
                }
                wait(0.01);
            }
            write("         a   b   c   d   e   f   g   h  ");
        }
    }
}
