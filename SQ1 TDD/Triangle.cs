using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ1_TDD
{
    class Triangle
    {
        public double sideA { get; set; }
        public double sideB { get; set; }
        public double sideC { get; set; }
        double angleA { get; set; }
        double angleB { get; set; }
        public double angleC { get; set; }
        public double Area { get; set; }

        public void calculateAngle()
        {
            
        }
        public void calculateHypotenuse()
        {
            double intermediate = Math.Pow(sideA,2) + Math.Pow(sideB, 2);
            sideC = Math.Sqrt(intermediate);
            
        }
        public void calculateArea()
        {
            Area = 0.5 * sideA * sideB;
        }
    }
}
