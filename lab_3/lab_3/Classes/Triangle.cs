using System;

namespace lab_3
{
    class Triangle : ITriangle
    {
        protected double sideA, sideB, sideC, area, perimeter;

        public double SideA
        {
            get { return sideA; }
        }
        public double SideB
        {
            get { return sideB; }
        }
        public double SideC
        {
            get { return sideC; }
        }

        /// <summary>
        /// Площа трикутника
        /// </summary>
        public double Area
        {
            get { return area; }
        }

        /// <summary>
        /// Периметр трикутника
        /// </summary>
        public double Perimeter
        {
            get { return perimeter; }
        }

        // ------------------- Конструктори -------------------

        /// <summary>
        /// Трикутник зі сторонами (1, 1, 1)
        /// </summary>
        public Triangle()
        {
            sideA = sideB = sideC = 1;
            perimeter = 3;
            area = Math.Sqrt(3) / 4;
        }

        /// <summary>
        /// Трикутник з вказаними сторонами
        /// </summary>
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Сторона має бути більшою за 0!");
            }
            if (a >= b + c || b >= a + c || c >= a + b)
            {
                throw new ArgumentException("Не існує трикутника з такими сторонами!");
            }

            sideA = a;
            sideB = b;
            sideC = c;
            perimeter = a + b + c;
            area = CalcArea();
        }

        // ------------------- Ф-ції -------------------

        // Радіус вписаного / описаного кола
        public virtual double GetInCircleRadius()
        {
            return 2 * area / perimeter;
        }

        public virtual double GetCircumCircleRadius()
        {
            return sideA * sideB * sideC / (4 * area);
        }

        // формула Герона для площі
        /// <summary>
        /// Обраховує площу цього трикутника
        /// </summary>
        /// <returns>Площа трикутника</returns>
        protected virtual double CalcArea()
        {
            double p = perimeter / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }
    }
}
