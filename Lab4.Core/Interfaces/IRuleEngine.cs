using Lab4.Core.Models;
using Lab4.Core.Models.ChessPieces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Core.Interfaces
{
    public interface IRuleEngine
    {
        void ApplyRules(int[,] board, Piece piece, Movement movement);
    }
}
