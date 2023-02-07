using System;

namespace lab_1
{
    class TParallelepiped : TRectangle
    {
        protected double h;


        public TParallelepiped()
        {
            h = 0;
        }
        public TParallelepiped(double a, double b, double h) : base(a, b)
        {
            this.h = h;
        }
        public TParallelepiped(TParallelepiped pp) : base (pp)
        {
            h = pp.h;
        }

        public void set_h(double h)
        {
            this.h = h;
        }

        public double get_h()
        {
            return h;
        }

        public override double area()
        {
            return 2* (side_a * side_b + side_a * h + side_b * h);
        }

        public override double perimeter()
        {
            return (side_a + side_b + h) * 4;
        }

        public double volume()
        {
            return side_a * side_b  * h;
        }

        public void compare(TParallelepiped pp2)
        {
            Console.SetCursorPosition(Console.WindowWidth * 1 / 4, Console.CursorTop);
            Console.Write("Паралелепіпед 1");
            Console.SetCursorPosition(Console.WindowWidth * 5 / 8, Console.CursorTop);
            Console.WriteLine("Паралелепіпед 2");

            Console.Write("Сторона a");
            Console.SetCursorPosition(Console.WindowWidth * 1 / 4, Console.CursorTop);
            Console.Write(side_a);
            Console.SetCursorPosition(Console.WindowWidth * 5 / 8, Console.CursorTop);
            Console.WriteLine(pp2.side_a);

            Console.Write("Сторона b");
            Console.SetCursorPosition(Console.WindowWidth * 1 / 4, Console.CursorTop);
            Console.Write(side_b);
            Console.SetCursorPosition(Console.WindowWidth * 5 / 8, Console.CursorTop);
            Console.WriteLine(pp2.side_b);

            Console.Write("Висота h");
            Console.SetCursorPosition(Console.WindowWidth * 1 / 4, Console.CursorTop);
            Console.Write(h);
            Console.SetCursorPosition(Console.WindowWidth * 5 / 8, Console.CursorTop);
            Console.WriteLine(pp2.h);

            Console.Write("Периметр");
            Console.SetCursorPosition(Console.WindowWidth * 1 / 4, Console.CursorTop);
            Console.Write(perimeter());
            Console.SetCursorPosition(Console.WindowWidth * 5 / 8, Console.CursorTop);
            Console.WriteLine(pp2.perimeter());

            Console.Write("Площа");
            Console.SetCursorPosition(Console.WindowWidth * 1 / 4, Console.CursorTop);
            Console.Write(area());
            Console.SetCursorPosition(Console.WindowWidth * 5 / 8, Console.CursorTop);
            Console.WriteLine(pp2.area());

            Console.Write("Об'єм");
            Console.SetCursorPosition(Console.WindowWidth * 1 / 4, Console.CursorTop);
            Console.Write(volume());
            Console.SetCursorPosition(Console.WindowWidth * 5 / 8, Console.CursorTop);
            Console.WriteLine(pp2.volume());
            Console.WriteLine();


            double[] sides1 = {side_a, side_b, h}, sides2 = {pp2.side_a, pp2.side_b, pp2.h};
            Array.Sort(sides1);
            Array.Sort(sides2);

            if (System.Linq.Enumerable.SequenceEqual(sides1, sides2))
            {
                Console.WriteLine("Паралелепіпеди рівні");
            }
            else if (sides1[0] / sides2[0] == sides1[1] / sides2[1] &&
                sides1[0] / sides2[0] == sides1[2] / sides2[2])
            {
                Console.WriteLine("Паралелепіпеди подібні");
            }
            else
            {
                Console.WriteLine("Паралелепіпеди не рівні і не подібні");
            }
        }

        public static TParallelepiped operator +(TParallelepiped pp1, TParallelepiped pp2)
        {
            return new TParallelepiped(pp1.get_a() + pp2.get_a(), pp1.get_b() + pp2.get_b(), pp1.get_h() + pp2.get_h());
        }

        public static TParallelepiped operator -(TParallelepiped pp1, TParallelepiped pp2)
        {
            return new TParallelepiped(Math.Abs(pp1.get_a() - pp2.get_a()),
                Math.Abs(pp1.get_b() - pp2.get_b()), Math.Abs(pp1.get_h() - pp2.get_h()));
        }

        public static TParallelepiped operator *(TParallelepiped pp1, double n)
        {
            return new TParallelepiped(Math.Abs(pp1.get_a() * n), Math.Abs(pp1.get_b() * n), Math.Abs(pp1.get_h() * n));
        }

        public override void enterSides()
        {
            base.enterSides();
            string message = "Введіть висоту паралелепіпеда: ";
            Console.WriteLine(message);
            h = (Input.inputDouble(0, message: message));
        }

        public override void showSides()
        {
            base.showSides();
            Console.WriteLine("Висота h = " + h);
        }
    }
}
