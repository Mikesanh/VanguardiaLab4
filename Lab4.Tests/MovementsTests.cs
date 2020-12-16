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
    }
}

