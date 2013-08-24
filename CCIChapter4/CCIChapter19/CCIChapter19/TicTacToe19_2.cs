using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCIChapter19
{
    class TicTacToe19_2
    {
        //if hasWon() method is called multiple times, then our implementation should be,
        //1. board size = 9, To win, we should have 3 same symbols in a row or col or diag
        //2. Therefore there are 3^9 ~ 20000 final boards possible
        //3. Precompute those boards and store them in a dictionary or an array of size 20000
        //4. Indexes of the array represents the board and value in that index indicates that if a someone has won

        static bool[] boards = new bool[20000];

        bool hasBoard(int board)
        {
            return boards[board];
        }

        //If hasOne is only called once, then, validate the board and see if any one has won

        enum Piece { Empty, Red, Black};
        enum Check { Row, Col, Diag, RevDiag };

        static Piece getIthColor(Piece[,] board, int index, int var, Check check)
        {
            if (check == Check.Row)
                return board[index, var];
            else if (check == Check.Col)
                return board[var, index];
            else if (check == Check.Diag)
                return board[var, var];
            else if (check == Check.RevDiag)
                return board[board.GetLength(0) - 1 - var, var];
            else
                return Piece.Empty;
        }
        
        static Piece getWinner(Piece[,] board, int fixedIndex, Check check)
        {
            Piece color = getIthColor(board, fixedIndex, 0, check);
            if (color == Piece.Empty)
                return color;

            for (int var = 1; var < board.GetLength(0); var++)
                if (color != getIthColor(board, fixedIndex, var, check))
                    return Piece.Empty;

            return color;
        }

        static Piece hasWon(Piece[,] board)
        {
            int N = board.GetLength(0);

            Piece winner;

            for (int i = 0; i < N; i++)
            {
                if ((winner = getWinner(board, i, Check.Row)) != Piece.Empty)
                    return winner;

                if ((winner = getWinner(board, i, Check.Col)) != Piece.Empty)
                    return winner;
            }

            if ((winner = getWinner(board, -1, Check.Diag)) != Piece.Empty)
                return winner;

            if ((winner = getWinner(board, -1, Check.RevDiag)) != Piece.Empty)
                return winner;

            return Piece.Empty;
        }
    }
}
