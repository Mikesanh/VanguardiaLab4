using Lab4.Core.Interfaces;
using Lab4.Core.Models;
using Lab4.Core.Models.ChessPieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab4.Core.Models.Movements;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Lab4.Tests")]
namespace Lab4.Core.Rules
{
    internal class MovementsRuleEngine : IRuleEngine
    {
        private readonly IEnumerable<BaseRules> _rules;

        public MovementsRuleEngine(IEnumerable<BaseRules> rules)
        {
            _rules = rules;
        }

        public void ApplyRules(int[,] board, Piece piece, Movement movement)
        {
            if (_rules.Where(rule => rule.IsMatch(piece)).Any(rule => !rule.ValidateMovement(board, piece, movement)))
            {
                throw new ApplicationException(
                    $"Invalid movement {piece.PieceType}{movement.XPos}{movement.YPos}-{movement.NewXPos}{movement.NewYPos}");
            }
        }
    }
}
