﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Core.Models.ChessPieces
{
    public abstract class Piece
    {
        public readonly PieceType PieceType;
        public bool IsWhitePiece;

        protected Piece(PieceType pieceType, bool isWhitePiece)
        {
            PieceType = pieceType;
            IsWhitePiece = isWhitePiece;
        }
    }
}
