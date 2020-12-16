using System;
using System.Collections.Generic;
using System.Text;
using Lab4.Core.Interfaces;
using Lab4.Core.Models;
using Lab4.Core.Models.ChessPieces;
using Lab4.Core.Models.Movements;
using Lab4.Core.Rules;


namespace Lab4.Tests.Builders
{
    public class RulesTestBuilder
    {
        
        private BaseRules _rule;
        public int[,] Board;
        public Piece Piece;
        public Movement Movement;

        public RulesTestBuilder()
        {
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

        public RulesTestBuilder WithPawnRule()
        {
          
            _rule = new PawnMovement();
            return this;
        }
        public RulesTestBuilder WithKnightRule()
        {

            _rule = new KnightMovement();
            return this;
        }
        public RulesTestBuilder WithRookRule()
        {

            _rule = new RookMovement();
            return this;
        }



        public RulesTestBuilder WithPawnPiece()
        {
           
            Piece = new Pawn(PieceType.P, true);
            return this;
        }
        public RulesTestBuilder WithKnightPiece()
        {

            Piece = new Knight(PieceType.C, true);
            return this;
        }
        public RulesTestBuilder WithRookPiece()
        {

            Piece = new Rook(PieceType.T, true);
            return this;
        }

        public RulesTestBuilder WithMovement(Movement movement)
        {
            
            Movement = movement;
            return this;
        }

        public BaseRules Build()
        {
            return _rule;
        }

        
    }
}
