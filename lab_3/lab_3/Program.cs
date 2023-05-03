using System;

namespace lab_3
{
    class Program
    {
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            while (true)
            {
                // Користувацький інтерфейс
                // Вибір типу трикутника
                ITriangle triangle;

                string uiMessage = " Оберіть тип трикутника:" +
                    "\n 1 - Рівносторонній" +
                    "\n 2 - Рівнобедрений" +
                    "\n 3 - Довільний" +
                    "\n 4 - Прямокутний";


                Console.Clear();
                Console.WriteLine(uiMessage);
                int figType = Input.inputInt(1, 4, uiMessage);
                string description;

                // Ввід сторін
                switch (figType)
                {
                    case 1: // Рівносторонній
                        while (true)
                        {
                            Console.Clear();
                            string message = " Введіть сторону рівностороннього трикутника: ";
                            Console.Write(message);
                            double a = Input.inputDouble(0, message: " Помилка!" + message,
                                clearConsole: false, newLine: false);

                            try
                            {
                                triangle = new EquilateralTriangle(a);
                                description = " Рівносторонній трикутник зі стороною " + a;
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(" Помилка: " + ex.Message + " Повторіть ввід.");
                                Console.ReadKey();
                            }
                        }
                        break;
                    case 2: // Рівнобедрений
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine(" Ввід сторін рівнобедреного трикутника");
                            string message = " Введіть основу: ";
                            Console.Write(message);
                            double a = Input.inputDouble(0, message: " Помилка!" + message,
                                clearConsole: false, newLine: false);
                            message = " Введіть бічну сторону: ";
                            Console.Write(message);
                            double b = Input.inputDouble(0, message: " Помилка!" + message,
                                clearConsole: false, newLine: false);

                            try
                            {
                                triangle = new IsoscelesTriangle(a, b);
                                description = " Рівнобедрений трикутник з основою " + a +
                                    " та бічною стороною " + b;
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(" Помилка: " + ex.Message + " Повторіть ввід.");
                                Console.ReadKey();
                            }
                        }
                        break;
                    case 3: // Довільний
                    default:
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine(" Ввід сторін довільного трикутника");
                            string message = " Введіть сторону a: ";
                            Console.Write(message);
                            double a = Input.inputDouble(0, message: " Помилка!" + message,
                                clearConsole: false, newLine: false);
                            message = " Введіть сторону b: ";
                            Console.Write(message);
                            double b = Input.inputDouble(0, message: " Помилка!" + message,
                                clearConsole: false, newLine: false);
                            message = " Введіть сторону c: ";
                            Console.Write(message);
                            double c = Input.inputDouble(0, message: " Помилка!" + message,
                                clearConsole: false, newLine: false);

                            try
                            {
                                triangle = new Triangle(a, b, c);
                                description = " Трикутник зі сторонами (" + a +", " + b + ", " + c + ")";
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(" Помилка: " + ex.Message + " Повторіть ввід.");
                                Console.ReadKey();
                            }
                        }
                        break;
                    case 4: // Прямокутний
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine(" Ввід сторін прямокутного трикутника");
                            string message = " Введіть сторону a: ";
                            Console.Write(message);
                            double a = Input.inputDouble(0, message: " Помилка!" + message,
                                clearConsole: false, newLine: false);
                            message = " Введіть сторону b: ";
                            Console.Write(message);
                            double b = Input.inputDouble(0, message: " Помилка!" + message,
                                clearConsole: false, newLine: false);
                            message = " Введіть сторону c: ";
                            Console.Write(message);
                            double c = Input.inputDouble(0, message: " Помилка!" + message,
                                clearConsole: false, newLine: false);

                            try
                            {
                                triangle = new RightTriangle(a, b, c);
                                description = " Прямокутний трикутник зі сторонами ("
                                    + a + ", " + b + ", " + c + ")";
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(" Помилка: " + ex.Message + " Повторіть ввід.");
                                Console.ReadKey();
                            }
                        }
                        break;
                }

                Console.Clear();
                Console.WriteLine(description);

                // Створюємо об'єкти вписаного і описаного кола
                Circle inCircle = new(triangle.GetInCircleRadius());
                Circle circumCircle = new(triangle.GetCircumCircleRadius());

                // Вивід даних
                Console.WriteLine("\n Трикутник:" +
                    "\n\t Периметр: " + Math.Round(triangle.Perimeter, 2) +
                    "\n\t Площа: " + Math.Round(triangle.Area, 2));
                Console.WriteLine("\n Вписане коло:" +
                    "\n\t Радіус: " + Math.Round(inCircle.Radius, 2) +
                    "\n\t Довжина кола: " + Math.Round(inCircle.Perimeter, 2) +
                    "\n\t Площа круга: " + Math.Round(inCircle.Area, 2));
                Console.WriteLine("\n Описане коло:" +
                    "\n\t Радіус: " + Math.Round(circumCircle.Radius, 2) +
                    "\n\t Довжина кола: " + Math.Round(circumCircle.Perimeter, 2) +
                    "\n\t Площа круга: " + Math.Round(circumCircle.Area, 2));
                Console.ReadKey();
            }
        }
    }
}
