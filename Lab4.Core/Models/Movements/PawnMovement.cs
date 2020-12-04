using Lab4.Core.Models.ChessPieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4.Core.Models.Movements
{
    public class PawnMovement : BaseRules
    {
        public override bool IsMatch(Piece piece)
        {
            return piece.PieceType == PieceType.P;
        }

        public override bool ValidateMovement(int[,] board, Piece piece, Movement movement)
        {
           
            var validXPositionAfterMove = (int)movement.XPos;
            var validYPositionsAfterMove =
                GetWhiteValidResults(piece, movement).Union(GetBlackValidResults(piece, movement));
            return validXPositionAfterMove == (int)movement.NewXPos &&
                   validYPositionsAfterMove.Contains(movement.NewYPos);

        }

        private static IEnumerable<int> GetBlackValidResults(Piece piece, Movement movement)
        {
            var validResults = new List<int>();
            if (piece.IsWhitePiece)
            {
                return Enumerable.Empty<int>();
            }

            if (movement.YPos == 6)
            {
                validResults.Add(5);
                validResults.Add(4);
            }
            validResults.Add(++movement.YPos);
            return validResults;
        }

        private static IEnumerable<int> GetWhiteValidResults(Piece piece, Movement movement)
        {
            var validResults = new List<int>();
            if (!piece.IsWhitePiece)
            {
                return Enumerable.Empty<int>();
            }

            if (movement.YPos == 1)
            {
                validResults.Add(2);
                validResults.Add(3);
            }
            validResults.Add(++movement.YPos);
            return validResults;
        }
    }
}
