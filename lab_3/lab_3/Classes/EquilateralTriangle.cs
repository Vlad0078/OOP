using System;

namespace lab_3
{
    class EquilateralTriangle : IsoscelesTriangle
    {
        // ------------------- Конструктори -------------------

        /// <summary>
        /// Трикутник зі сторонами (1, 1, 1)
        /// </summary>
        public EquilateralTriangle() : base() { }

        /// <summary>
        /// Рівносторонній трикутник з вказаною стороною
        /// </summary>
        /// <param name="a">Сторона трикутника</param>
        public EquilateralTriangle(double a)
        {
            if (a <= 0)
            {
                throw new ArgumentException("Сторона має бути більшою за 0!");
            }
            sideA = sideB = sideC = a;
            perimeter = a * 3;
            area = CalcArea();
        }

        // ------------------- Ф-ції -------------------

        // Радіус вписаного / описаного кола
        public override double GetInCircleRadius()
        {
            return sideA / (2 * Math.Sqrt(3));
        }

        public override double GetCircumCircleRadius()
        {
            return sideA / Math.Sqrt(3);
        }

        protected override double CalcArea()
        {
            return sideA * sideA * Math.Sqrt(3) / 4;
        }
    }
}
