using System;
using Lab4.Core.Interfaces;
using Lab4.Core.Models;
using Lab4.Core.Models.ChessPieces;
using Lab4.Core.Rules;
using Lab4.Tests.Builders;
using Moq;
using Xunit;

namespace Lab4.Tests
{
    public class RuleEngineTests
    {
        [Fact]
        public void ApplyRules_InvalidMovement_Fails()
        {
            var testBuilder = new RuleEngineTestBuilder();
            var engine = testBuilder
                .WithInvalidMovement()
                .WithValidPiece()
                .Build();

            Assert.Throws<ApplicationException>(() => engine.ApplyRules(testBuilder.Board, testBuilder.Piece, testBuilder.Movement));
        }

        [Fact]
        public void ApplyRules_ValidMovement_Fails()
        {
            var testBuilder = new RuleEngineTestBuilder();
            var engine = testBuilder
                .WithValidMovement()
                .WithValidPiece()
                .Build();

            var exception = Record.Exception(() =>
                engine.ApplyRules(testBuilder.Board, testBuilder.Piece, testBuilder.Movement));
            Assert.Null(exception);
        }
    }
}
