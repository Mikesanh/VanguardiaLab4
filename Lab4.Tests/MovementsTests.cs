using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Lab4.Tests.Builders;

namespace Lab4.Tests
{
    [TestClass]
    public class MovementsTests
    {
        [Theory]
        [InlineData("pawnValidMovement")]
        public void ValidateMovement_PawnValidMovement_Succeeds(string jsonKey)
        {
            var movement = TestDataSource.GetMovement(jsonKey);
            var testBuilder = new RulesTestBuilder();
            var rule = testBuilder
                .WithPawnRule()
                .WithPawnPiece()
                .WithMovement(movement)
                .Build();

            Xunit.Assert.NotNull(movement);

            var result = rule.ValidateMovement(testBuilder.Board, testBuilder.Piece, testBuilder.Movement);
            Xunit.Assert.True(result);
        }

        [Theory]
        [InlineData("pawnInvalidMovement")]
        public void ValidateMovement_PawnInvalidMovement_Fails(string jsonKey)
        {
            var movement = TestDataSource.GetMovement(jsonKey);
            var testBuilder = new RulesTestBuilder();
            var rule = testBuilder
                .WithPawnRule()
                .WithPawnPiece()
                .WithMovement(movement)
                .Build();

            Xunit.Assert.NotNull(movement);

            var result = rule.ValidateMovement(testBuilder.Board, testBuilder.Piece, testBuilder.Movement);
            Xunit.Assert.False(result);
        }
        [Theory]
        [InlineData("knightValidMovement")]
        public void ValidateMovement_KnightValidMovement_Succeeds(string jsonKey)
        {
            var movement = TestDataSource.GetMovement(jsonKey);
            var testBuilder = new RulesTestBuilder();
            var rule = testBuilder
                .WithKnightRule()
                .WithKnightPiece()
                .WithMovement(movement)
                .Build();

            Xunit.Assert.NotNull(movement);

            var result = rule.ValidateMovement(testBuilder.Board, testBuilder.Piece, testBuilder.Movement);
            Xunit.Assert.True(result);
        }

        [Theory]
        [InlineData("knightInvalidMovement")]
        public void ValidateMovement_KnightInvalidMovement_Fails(string jsonKey)
        {
            var movement = TestDataSource.GetMovement(jsonKey);
            var testBuilder = new RulesTestBuilder();
            var rule = testBuilder
                .WithKnightRule()
                .WithKnightPiece()
                .WithMovement(movement)
                .Build();

            Xunit.Assert.NotNull(movement);

            var result = rule.ValidateMovement(testBuilder.Board, testBuilder.Piece, testBuilder.Movement);
            Xunit.Assert.False(result);
        }

        [Theory]
        [InlineData("rookValidMovement")]
        public void ValidateMovement_RookValidMovement_Succeeds(string jsonKey)
        {
            var movement = TestDataSource.GetMovement(jsonKey);
            var testBuilder = new RulesTestBuilder();
            var rule = testBuilder
                .WithRookRule()
                .WithRookPiece()
                .WithMovement(movement)
                .Build();

            Xunit.Assert.NotNull(movement);

            var result = rule.ValidateMovement(testBuilder.Board, testBuilder.Piece, testBuilder.Movement);
            Xunit.Assert.True(result);
        }
        [Theory]
        [InlineData("rookInvalidMovement")]
        public void ValidateMovement_RookInvalidMovement_Fails(string jsonKey)
        {
            var movement = TestDataSource.GetMovement(jsonKey);
            var testBuilder = new RulesTestBuilder();
            var rule = testBuilder
                .WithRookRule()
                .WithRookPiece()
                .WithMovement(movement)
                .Build();

            Xunit.Assert.NotNull(movement);

            var result = rule.ValidateMovement(testBuilder.Board, testBuilder.Piece, testBuilder.Movement);
            Xunit.Assert.False(result);
        }
    }
}

