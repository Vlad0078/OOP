using System;


namespace lab_1
{
    class TRectangle
    {
        protected double side_a, side_b;


        public TRectangle()
        {
            side_a = 1;
            side_b = 1;
        }
        public TRectangle(double a, double b)
        {
            side_a = a;
            side_b = b;
        }
        public TRectangle(TRectangle rect)
        {
            side_a = rect.side_a;
            side_b = rect.side_b;
        }


        public void set_a(double a)
        {
            side_a = a;
        }
        public void set_b(double b)
        {
            side_b = b;
        }


        public double get_a()
        {
            return side_a;
        }
        public double get_b()
        {
            return side_b;
        }


        public virtual double area()
        {
            return side_a * side_b;
        }


        public virtual double perimeter()
        {
            return (side_a + side_b) * 2;
        }

        public bool Equals(TRectangle r2)
        {
            return side_a == r2.side_a && side_b == r2.side_b;
        }

        public void compare(TRectangle rect2)
        {
            Console.SetCursorPosition(Console.WindowWidth * 1 / 4, Console.CursorTop);
            Console.Write("Прямокутник 1");
            Console.SetCursorPosition(Console.WindowWidth * 5 / 8, Console.CursorTop);
            Console.WriteLine("Прямокутник 2");

            Console.Write("Сторона a");
            Console.SetCursorPosition(Console.WindowWidth * 1 / 4, Console.CursorTop);
            Console.Write(side_a);
            Console.SetCursorPosition(Console.WindowWidth * 5 / 8, Console.CursorTop);
            Console.WriteLine(rect2.side_a);

            Console.Write("Сторона b");
            Console.SetCursorPosition(Console.WindowWidth * 1 / 4, Console.CursorTop);
            Console.Write(side_b);
            Console.SetCursorPosition(Console.WindowWidth * 5 / 8, Console.CursorTop);
            Console.WriteLine(rect2.side_b);

            Console.Write("Периметр");
            Console.SetCursorPosition(Console.WindowWidth * 1 / 4, Console.CursorTop);
            Console.Write(perimeter());
            Console.SetCursorPosition(Console.WindowWidth * 5 / 8, Console.CursorTop);
            Console.WriteLine(rect2.perimeter());

            Console.Write("Площа");
            Console.SetCursorPosition(Console.WindowWidth * 1 / 4, Console.CursorTop);
            Console.Write(area());
            Console.SetCursorPosition(Console.WindowWidth * 5 / 8, Console.CursorTop);
            Console.WriteLine(rect2.area());
            Console.WriteLine();


            if ((side_a == rect2.side_a && side_b == rect2.side_b) ||
                (side_a == rect2.side_b && side_b == rect2.side_a))
            {
                Console.WriteLine("Прямокутники рівні");
            }
            else if ((side_a / side_b == rect2.side_a / rect2.side_b) ||
                (side_a / side_b == rect2.side_b / rect2.side_a))
            {
                Console.WriteLine("Прямокутники подібні");
            }
            else
            {
                Console.WriteLine("Прямокутники не рівні і не подібні");
            }
        }


        public static TRectangle operator +(TRectangle rect1, TRectangle rect2)
        {
            return new TRectangle(rect1.get_a() + rect2.get_a(), rect1.get_b() + rect2.get_b());
        }

        /// <summary>
        /// Комутативна операція. Результуюча сторона вираховується як модуль різниці сторін прямокутників
        /// </summary>
        public static TRectangle operator -(TRectangle rect1, TRectangle rect2)
        {
            return new TRectangle(Math.Abs(rect1.get_a() - rect2.get_a()),
                Math.Abs(rect1.get_b() - rect2.get_b()));
        }

        public static TRectangle operator *(TRectangle rect1, double n)
        {
            return new TRectangle(Math.Abs(rect1.get_a() * n), Math.Abs(rect1.get_b() * n));
        }

        public virtual void enterSides()
        {
            string message = "Введіть сторону a: ";
            Console.WriteLine(message);
            side_a = (Input.inputDouble(0, message: message));

            message = "Введіть сторону b: ";
            Console.WriteLine(message);
            side_b = (Input.inputDouble(0, message: message));
        }

        public virtual void showSides()
        {
            Console.WriteLine("Сторона a = " + side_a);
            Console.WriteLine("Сторона b = " + side_b);
        }
    }
}
