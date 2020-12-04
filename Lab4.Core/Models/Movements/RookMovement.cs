using Lab4.Core.Models.ChessPieces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Core.Models.Movements
{
    public class RookMovement : Rules
    {
        public override bool IsMatch(Piece piece)
        {
            return piece.PieceType == PieceType.T;
        }

        public override bool ValidateMovement(int[,] board, Piece piece, Movement movement)
        {
            return true;
        }
    }
}
