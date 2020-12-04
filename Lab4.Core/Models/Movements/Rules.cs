using System;
using System.Collections.Generic;
using System.Text;
using Lab4.Core.Interfaces;
using Lab4.Core.Models.ChessPieces;

namespace Lab4.Core.Models.Movements
{
    public abstract class Rules
    {
        
        public abstract bool IsMatch(Piece piece);

        public abstract bool ValidateMovement(int[,] board, Piece piece, Movement movement);
    }
}
