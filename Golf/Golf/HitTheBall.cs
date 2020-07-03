using System;
using System.Collections.Generic;
using System.Text;

namespace Golf
{
    class HitTheBall
    {

        public double DistanceToHole { get; set; }     //Distance left to hole in meters
        public double StrokeLength { get; set; }             //How long the ball went in meters
        public int Angle { get; set; }              //Angle for altitude
        public int Velocity { get; set; }           //Velocity for the boll when clup hitting


        public double CalculateLenghtOfStroke()
        {
            StrokeLength = (Math.Round((Math.Pow(Velocity, 2) / 9.8 * Math.Sin(2 * (Math.PI / 180) * Angle)), 0));
            return StrokeLength;
        }

        public double CalculateDistanceToHole()
        {
            DistanceToHole -= StrokeLength;
            
            if (DistanceToHole < 0)
            {
                DistanceToHole *= (-1);
            }

            if (DistanceToHole > 380)
            {
                throw new DistanceException("Out of range!!  You lost!");
            }
            else
            {
                return DistanceToHole;
            }

        }

    }

}

