using Lab4.Core.Models;
using Lab4.Core.Models.ChessPieces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Core
{
    public class PieceFactory
    {
        private readonly Dictionary<PieceType, string> _pieces;

        public PieceFactory()
        {
            _pieces = new Dictionary<PieceType, string>()
            {
                { PieceType.C, "Knight" },
                { PieceType.T, "Rook"}
            };
        }
        public Piece Create(Movement movement)
        {
           
            try
            {
                return (Piece)Activator.CreateInstance(
                    Type.GetType($"Chess.Core.Models.Pieces.{_pieces[movement.Piece]}Piece"), new object[]
                    {
                        movement.Piece,
                        movement.IsWhitePiece
                    });
            }
            catch
            {
                return new Pawn(PieceType.P,movement.IsWhitePiece);
            }
        }
    }
}
