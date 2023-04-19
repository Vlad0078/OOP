using System;

namespace lab_3
{
    class IsoscelesTriangle : Triangle
    {
        // ------------------- Конструктори -------------------

        /// <summary>
        /// Трикутник зі сторонами (1, 1, 1)
        /// </summary>
        public IsoscelesTriangle() : base() { }

        /// <summary>
        /// Рівнобедрений трикутник з вказаними сторонами
        /// </summary>
        /// <param name="a">Основа</param>
        /// <param name="b">Бічна сторона</param>
        public IsoscelesTriangle(double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentException("Сторона має бути більшою за 0!");
            }
            if (a >= 2 * b)
            {
                throw new ArgumentException("Не існує трикутника з такими сторонами!");
            }

            sideA = a;
            sideB = sideC = b;
            perimeter = a + b * 2;
            area = CalcArea();
        }

        // ------------------- Ф-ції -------------------

        // Радіус вписаного кола (для описаного залишається формула з Triangle)
        public override double GetInCircleRadius()
        {
            return sideA / 2 * Math.Sqrt((2 * sideB - sideA) / (2 * sideB + sideA));
        }
    }
}
