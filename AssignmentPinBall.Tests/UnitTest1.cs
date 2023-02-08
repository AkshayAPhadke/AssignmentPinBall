using System;
using Xunit;
using AssignmentPinBall.Data;

namespace AssignmentPinBall.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Game_Mix_1()
        {
            PinBallBowling game = new PinBallBowling();
            game.Strike();
            game.Spare(9);
            game.Spare(5);
            game.OpenFrame(7, 2);
            game.Strike();
            game.Strike();
            game.Strike();
            game.OpenFrame(9, 0);
            game.Spare(8);
            game.FinalFrame(9, 1, 10);

            int endGame = game.CalculateScoreAfterGameEnds();
            Assert.Equal(187, game.FinalScore);
            Assert.Equal(187, endGame);

        }

        [Fact]
        public void Game_Mix_2()
        {
            PinBallBowling game = new PinBallBowling();
            game.Strike();
            game.Spare(8);
            game.Spare(9);
            game.OpenFrame(8, 0);
            game.Strike();
            game.Strike();
            game.Spare(9);
            game.Spare(9);
            game.Strike();
            game.FinalFrame(10, 9, 1);
            int endGame = game.CalculateScoreAfterGameEnds();

            Assert.Equal(202, game.FinalScore);
            Assert.Equal(202, endGame);

        }

        [Fact]
        public void Game_Mix_3()
        {
            PinBallBowling game = new PinBallBowling();
            game.Spare(7);
            game.Strike();
            game.Strike();
            game.OpenFrame(8, 1);
            game.Spare(9);
            game.OpenFrame(8, 1);
            game.Strike();
            game.Spare(9);
            game.Spare(8);
            game.FinalFrame(6, 1, 0);
            int endGame = game.CalculateScoreAfterGameEnds();

            Assert.Equal(164, game.FinalScore);
            Assert.Equal(164, endGame);

        }

        [Fact]
        public void Game_Mix_4()
        {
            PinBallBowling game = new PinBallBowling();
            game.Strike();
            game.Strike();
            game.Strike();
            game.Strike();
            game.Strike();
            game.Strike();
            game.Strike();
            game.Strike();
            game.Spare(6);
            game.FinalFrame(10, 10, 10);
            int endGame = game.CalculateScoreAfterGameEnds();

            Assert.Equal(276, game.FinalScore);
            Assert.Equal(276, endGame);

        }

        [Fact]
        public void Game_Mix_AllStrikes()
        {
            PinBallBowling game = new PinBallBowling();
            game.Strike();
            game.Strike();
            game.Strike();
            game.Strike();
            game.Strike();
            game.Strike();
            game.Strike();
            game.Strike();
            game.Strike();
            game.FinalFrame(10, 10, 10);
            int endGame = game.CalculateScoreAfterGameEnds();

            Assert.Equal(300, game.FinalScore);
            Assert.Equal(300, endGame);

        }
    }
}
