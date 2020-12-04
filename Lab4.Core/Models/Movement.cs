using Lab4.Core.Models.ChessPieces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Core.Models
{
    public class Movement
    {
        public PieceType Piece { get; set; }
        public XCoordinates XPos { get; set; }

        private int _YPos;

        public int YPos
        {
            get => _YPos;
            set => _YPos = value - 1;
        }

        public XCoordinates NewXPos { get; set; }

        private int _newYPos;

        public int NewYPos
        {
            get => _newYPos;
            set => _newYPos = value - 1;
        }

        public bool IsWhitePiece { get; set; }
    }
}
