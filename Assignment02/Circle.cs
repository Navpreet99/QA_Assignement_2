using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Circle
    {
        private int _radius;

        public Circle()
        {
            _radius = 1;
        }

        public Circle(int radius)
        {
            _radius = radius;
        }

        public int GetRadius()
        {
            return _radius;
        }

        public void SetRadius(int radius)
        {
            _radius = radius;
        }

        public double GetCircumference()
        {
            return 2 * System.Math.PI * _radius;
        }

        public double GetArea()
        {
            return System.Math.PI * System.Math.Pow(_radius, 2);
        }
    }
}
