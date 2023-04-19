using System;

namespace lab_3
{
    class RightTriangle : Triangle
    {
        // ------------------- Конструктори -------------------

        /// <summary>
        /// Трикутник зі сторонами (3, 4, 5)
        /// </summary>
        public RightTriangle()
        {
            sideA = 3;
            sideB = 4;
            sideC = 5;
            perimeter = 12;
            area = 6;
        }

        /// <summary>
        /// Прямокутний трикутник з вказаними сторонами
        /// </summary>
        public RightTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Сторона має бути більшою за 0!");
            }

            // Сторону А зробимо гіпотенузою
            if (b > a)
            {
                double buffer = a;
                a = b;
                b = buffer;
            }
            if (c > a)
            {
                double buffer = a;
                a = c;
                c = buffer;
            }

            if (a * a != b * b + c * c)
            {
                throw new ArgumentException("Прямокутний трикутник з такими сторонами не існує!");
            }

            sideA = a;
            sideB = b;
            sideC = c;
            perimeter = a + b + c;
            area = CalcArea();
        }

        // ------------------- Ф-ції -------------------

        // Радіус вписаного / описаного кола
        public override double GetInCircleRadius()
        {
            return (sideB + sideC -sideA) / 2;
        }

        public override double GetCircumCircleRadius()
        {
            return sideA / 2;
        }

        protected override double CalcArea()
        {
            return sideB * sideC / 2;
        }
    }
}
