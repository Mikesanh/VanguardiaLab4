using Lab4.Core.Models.ChessPieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4.Core.Models.Movements
{
    public class KnightMovement : Rules
    {
        public override bool IsMatch(Piece piece)
        {
            return piece.PieceType == PieceType.C;
        }

        public override bool ValidateMovement(int[,] board, Piece piece, Movement movement)
        {
            var validMovements = new List<(int, int)>
            {
                (1, 2),
                (1, -2),
                (2, 1),
                (2, -1),
                (-1, -2),
                (-1, 2),
                (-2, -1),
                (-2, 1)
            };

            return validMovements.Any(x =>
          (int)movement.XPos + x.Item1 == (int)movement.NewYPos && movement.YPos + x.Item2 == movement.NewYPos);
        }
    }
}
