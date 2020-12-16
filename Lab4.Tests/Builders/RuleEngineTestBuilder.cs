using System;
using System.Collections.Generic;
using System.Text;
using Lab4.Core.Interfaces;
using Lab4.Core.Models;
using Lab4.Core.Models.ChessPieces;
using Lab4.Core.Models.Movements;
using Lab4.Core.Rules;
using Moq;
namespace Lab4.Tests.Builders
{
    public class RuleEngineTestBuilder
    {
        private IEnumerable<BaseRules> _rules;
        public int[,] Board;
        public Piece Piece;
        public Movement Movement;

        public RuleEngineTestBuilder()
        {
            _rules = new List<BaseRules>();
            Board = new[,]
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

        public RuleEngineTestBuilder WithInvalidMovement()
        {
            
            CreateRules(false);
            return this;
        }

        public RuleEngineTestBuilder WithValidMovement()
        {
           
            CreateRules(true);
            return this;
        }

        public RuleEngineTestBuilder WithValidPiece()
        {
           
            Piece = new Pawn(PieceType.P, true);
            return this;
        }

        public IRuleEngine Build()
        {
            return new MovementsRuleEngine(_rules);
        }

        private void CreateRules(bool expectedValidationResult)
        {
            Movement = new Movement();
            var ruleMock = new Mock<PawnMovement>();
            ruleMock.Setup(r => r.ValidateMovement(It.IsAny<int[,]>(), It.IsAny<Piece>(), It.IsAny<Movement>()))
                .Returns(expectedValidationResult);
            ruleMock.Setup(r => r.IsMatch(It.IsAny<Piece>()))
                .Returns(true);
            _rules = new[] { ruleMock.Object };
        }
    }
}
