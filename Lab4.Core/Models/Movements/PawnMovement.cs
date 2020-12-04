using Lab4.Core.Models.ChessPieces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Core.Models.Movements
{
    public class PawnMovement : Rules
    {
        public override bool IsMatch(Piece piece)
        {
            return piece.PieceType == PieceType.P;
        }

        public override bool ValidateMovement(int[,] board, Piece piece, Movement movement)
        {
            throw new NotImplementedException();
        }
    }
}
