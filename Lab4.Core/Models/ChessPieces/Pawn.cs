using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Core.Models.ChessPieces
{
    public class Pawn: Piece
    {
        public Pawn(PieceType pieceType, bool isWhitePiece) 
            : base(pieceType, isWhitePiece)
        {
        }
    }
}
