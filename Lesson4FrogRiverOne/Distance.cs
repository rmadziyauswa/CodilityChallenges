using System;
namespace Lesson4FrogRiverOne
{
    public class Distance
    {
        public double averagePlaneDistance(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            var distanceBetween1And2 = DistanceBetweenTwoPoints(x1, y1, x2, y2);
            var distanceBetween1And3 = DistanceBetweenTwoPoints(x1, y1, x3, y3);
            var distanceBetween2And3 = DistanceBetweenTwoPoints(x2, y2, x3, y3);
            var averageDistance = (distanceBetween1And2 + distanceBetween1And3 + distanceBetween2And3) / 3;
            return averageDistance;
        }

        private double DistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
    }
}
