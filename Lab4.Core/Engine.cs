using Lab4.Core.Interfaces;
using Lab4.Core.Models;
using System;

namespace Lab4.Core
{
    public class Engine : IEngine 
    {
        private readonly PieceFactory _pieceFactory;
        private readonly IRuleEngine _ruleEngine;
        private readonly int[,] _board;
        public Engine(
            PieceFactory pieceFactory,
            IRuleEngine ruleEngine)
        {
            _pieceFactory = pieceFactory;
            _ruleEngine = ruleEngine;
            _board = new[,]
            {
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 }
            };
        }
        public void ExecuteMovement(Movement movement)
        {
            try
            {
                var piece = _pieceFactory.Create(movement);
                _ruleEngine.ApplyRules(_board, piece, movement);
                piece.Move(_board, movement);
            }
            catch (Exception e)
            {
                
                throw e;
            }
        }
    }
}
