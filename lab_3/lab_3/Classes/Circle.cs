using System;

namespace lab_3
{
    class Circle : IFigure
    {
        private double radius, area, perimeter;

        // ------------------- В-ті -------------------

        /// <summary>
        /// Радіус кола
        /// </summary>
        public double Radius
        {
            get { return radius; }
        }

        /// <summary>
        /// Площа круга
        /// </summary>
        public double Area
        { 
            get { return area; }
        }

        /// <summary>
        /// Довжина кола
        /// </summary>
        public double Perimeter
        {
            get { return perimeter; }
        }

        // ------------------- Конструктори -------------------

        /// <summary>
        /// Коло з радіусом 1
        /// </summary>
        public Circle()
        {
            radius = 1;
            area = Math.PI;
            perimeter = 2 * Math.PI;
        }

        /// <summary>
        /// Коло з вказаним радіусом
        /// </summary>
        /// <param name="radius">Радіус кола</param>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радіус має бути більшим за 0!");
            }
            this.radius = radius;
            area = Math.PI * radius * radius;
            perimeter = 2 * Math.PI * radius;
        }
    }
}
