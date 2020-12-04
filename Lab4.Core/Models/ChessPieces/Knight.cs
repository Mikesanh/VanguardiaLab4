using System;
using System.Collections.Generic;
using System.Text;
using Lab4.Core.Interfaces;

namespace Lab4.Core.Models.ChessPieces
{
    public class Knight : Piece
    {
        public Knight(PieceType pieceType, bool isWhitePiece) : base(pieceType, isWhitePiece)
        {
        }
    }
}
