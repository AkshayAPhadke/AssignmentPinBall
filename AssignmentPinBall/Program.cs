using System;
using AssignmentPinBall.Data;

namespace AssignmentPinBall
{
    class Program
    {
        static void Main(string[] args)
        {
            PinBallBowling game = new PinBallBowling();

            // Calculate Open Frame and Spare Balls in the frame 
            game.Strike();
            game.Spare(9);
            game.Spare(5);
            game.OpenFrame(7, 2);
            game.Strike();
            game.Strike();
            game.Strike();
            game.OpenFrame(9, 0);
            game.Spare(8);
            //game.Spare(7);
            game.FinalFrame(9, 1, 10);

            foreach (var frame in game.ListOfFrames)
                Console.WriteLine($"Total Score is :- {frame.TotalScore}");


            Console.ReadLine();

            //Console.WriteLine("Hello World!");
        }
    }
}
