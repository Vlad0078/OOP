using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            TRectangle figure = new TRectangle();
            figure.enterSides();
            while (true)
                figure = run_menu(figure);
        }

        static TRectangle run_menu (TRectangle figure) {


            while (true)
            {
                Console.Clear();
                string menu = "Оберіть дію:" +
                "\n 1 - Вивести сторони " + (figure is TParallelepiped ? "паралелепіпеда" : "прямокутника") +
                "\n 2 - Змінити сторони " + (figure is TParallelepiped ? "паралелепіпеда" : "прямокутника") +
                "\n 3 - Вивести площу " + (figure is TParallelepiped ? "паралелепіпеда" : "прямокутника") +
                "\n 4 - Вивести периметр " + (figure is TParallelepiped ? "паралелепіпеда" : "прямокутника") +
                "\n 5 - Порівняти з іншим " + (figure is TParallelepiped ? "паралелепіпедом" : "прямокутником") +
                "\n 6 - Виконати арифметичні дії над " + (figure is TParallelepiped ? "паралелепіпедом" : "прямокутником") +
                "\n 7 - Перемкнутись на роботу з " + (figure is TParallelepiped ? "прямокутником" : "прямокутним паралелепіпедом") +
                (figure is TParallelepiped ? "\n 8 - Вивести об'єм паралелепіпеда":"") +
                "\n 0 - Вихід";
                Console.WriteLine(menu);
                int choice = Input.inputInt(0, 8, menu);

                Console.Clear();
                switch (choice)
                {
                    case 1:
                        figure.showSides();
                        break;
                    case 2:
                        figure.enterSides();
                        break;
                    case 3:
                        if (figure is TParallelepiped)
                        {
                            Console.WriteLine("Площа паралелепіпеда зі сторонами основи " +
                                figure.get_a() + ", " + figure.get_b() + ", та висотою " + 
                                ((TParallelepiped)figure).get_h() + " = " + figure.area());
                        }
                        else
                        {
                            Console.WriteLine("Площа прямокутника зі сторонами " +
                                figure.get_a() + " та " + figure.get_b() + " = " + figure.area());
                        }
                        break;
                    case 4:
                        if (figure is TParallelepiped)
                        {
                            Console.WriteLine("Периметр паралелепіпеда зі сторонами основи " +
                                figure.get_a() + ", " + figure.get_b() + ", та висотою " +
                                ((TParallelepiped)figure).get_h() + " = " + figure.perimeter());
                        }
                        else
                        {
                            Console.WriteLine("Периметр прямокутника зі сторонами " +
                                figure.get_a() + " та " + figure.get_b() + " = " + figure.perimeter());
                        }
                        break;
                    case 5:
                        {
                            if (figure is TParallelepiped)
                            {
                                Console.WriteLine("Введіть сторони другого паралелепіпеда");
                                TParallelepiped figure2 = new TParallelepiped();
                                figure2.enterSides();
                                Console.Clear();
                                ((TParallelepiped)figure).compare(figure2);
                            }
                            else
                            {
                                Console.WriteLine("Введіть сторони другого прямокутника");
                                TRectangle figure2 = new TRectangle();
                                figure2.enterSides();
                                Console.Clear();
                                figure.compare(figure2);
                            }
                        }
                        break;
                    case 6:
                        Console.Clear();
                        string mathMenu = "Оберіть дію:" +
                        "\n 1 - Додавання" +
                        "\n 2 - Віднімання" +
                        "\n 3 - Множення";
                        Console.WriteLine(mathMenu);
                        int mathOp = Input.inputInt(1, 3, mathMenu);

                        Console.Clear();
                        {
                            TRectangle figure2;
                            TRectangle figure3;

                            if (figure is TParallelepiped) 
                            {
                                figure2 = new TParallelepiped();
                                figure3 = new TParallelepiped();
                            }
                            else
                            {
                                figure2 = new TRectangle();
                                figure3 = new TRectangle(); 
                            }

                            switch (mathOp)
                            {
                                case 1:
                                    Console.WriteLine("Введіть сторони прямокутника, який потрібно додати");
                                    figure2.enterSides();
                                    Console.Clear();

                                    if (figure is TParallelepiped)
                                    {
                                        figure3 = (TParallelepiped)figure + (TParallelepiped)figure2;

                                        Console.WriteLine("Паралелепіпед(" + figure.get_a() + "x" +
                                        figure.get_b() + "x" + ((TParallelepiped)figure).get_h() +
                                        ") + Паралелепіпед(" + figure2.get_a() + "x" +
                                        figure2.get_b() + "x" + ((TParallelepiped)figure2).get_h() +
                                        ") = Паралелепіпед(" + figure3.get_a() + "x" +
                                        figure3.get_b() + "x" + ((TParallelepiped)figure3).get_h() + ")");
                                    }
                                    else
                                    {
                                        figure3 = figure + figure2;

                                        Console.WriteLine("Прямокутник(" + figure.get_a() + "x" + figure.get_b() +
                                        ") + Прямокутник(" + figure2.get_a() + "x" + figure2.get_b() +
                                        ") = Прямокутник(" + figure3.get_a() + "x" + figure3.get_b() + ")");
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Введіть сторони прямокутника, який потрібно відняти");
                                    figure2.enterSides();
                                    Console.Clear();

                                    if (figure is TParallelepiped)
                                    {
                                        figure3 = (TParallelepiped)figure - (TParallelepiped)figure2;
                                        Console.WriteLine("Паралелепіпед(" + figure.get_a() + "x" +
                                        figure.get_b() + "x" + ((TParallelepiped)figure).get_h() +
                                        ") - Паралелепіпед(" + figure2.get_a() + "x" +
                                        figure2.get_b() + "x" + ((TParallelepiped)figure2).get_h() +
                                        ") = Паралелепіпед(" + figure3.get_a() + "x" +
                                        figure3.get_b() + "x" + ((TParallelepiped)figure3).get_h() + ")");
                                    }
                                    else
                                    {
                                        figure3 = figure - figure2;
                                        Console.WriteLine("Прямокутник(" + figure.get_a() + "x" + figure.get_b() +
                                        ") - Прямокутник(" + figure2.get_a() + "x" + figure2.get_b() +
                                        ") = Прямокутник(" + figure3.get_a() + "x" + figure3.get_b() + ")");
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Введіть множник");
                                    double n = Input.inputDouble(0, message: "Введіть невід'ємний множник!");

                                    if (figure is TParallelepiped)
                                    {
                                        figure3 = (TParallelepiped)figure * n;
                                        Console.WriteLine("Паралелепіпед(" + figure.get_a() + "x" +
                                        figure.get_b() + "x" + ((TParallelepiped)figure).get_h() +
                                        ") * " + n + " = Паралелепіпед(" + figure3.get_a() + "x" +
                                        figure3.get_b() + "x" + ((TParallelepiped)figure3).get_h() + ")");
                                    }
                                    else
                                    {
                                        figure3 = figure * n;
                                        Console.WriteLine("Прямокутник(" + figure.get_a() + "x" + figure.get_b() +
                                            ") * " + n + " = Прямокутник(" + figure3.get_a() + "x" + figure3.get_b() + ")");
                                    }
                                    break;
                            }
                        }
                        break;
                    case 7:
                        if (figure is TParallelepiped)
                        {
                            TRectangle rect = new TRectangle();
                            rect.enterSides();
                            return rect;
                        }
                        else
                        {
                            TParallelepiped pp = new TParallelepiped();
                            pp.enterSides();
                            return pp;
                        }
                    case 8:
                        if (figure is TParallelepiped)
                        {
                            Console.WriteLine("Об'єм паралелепіпеда зі сторонами основи " +
                                figure.get_a() + ", " + figure.get_b() + ", та висотою " +
                                ((TParallelepiped)figure).get_h() + " = " + ((TParallelepiped)figure).volume());
                        }
                        else
                            continue;
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }

                Console.WriteLine("Для продовження натисніть Enter . . . ");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            }
        }
    }
}
