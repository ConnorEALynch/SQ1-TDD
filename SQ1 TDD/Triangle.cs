using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ1_TDD
{
    public class Triangle
    {
        public double sideA { get; set; }
        public double sideB { get; set; }
        public double sideC { get; set; }
        public double angleA { get; set; }
        public double angleB { get; set; }
        public double angleC { get; set; }
        public double Area { get; set; }

        public void calculateAngle()
        {
            double remainingDegrees = 180;
            remainingDegrees -= angleA;
            angleC = remainingDegrees - angleB;
        }
        public void calculateHypotenuse()
        {
            double intermediate = Math.Pow(sideA,2) + Math.Pow(sideB, 2);
            sideC = Math.Round(Math.Sqrt(intermediate),3);
            
        }
        public void calculateArea()
        {
            Area = 0.5 * sideA * sideB;
        }
    }
}
