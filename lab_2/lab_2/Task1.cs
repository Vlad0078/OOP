using System;

namespace lab_2
{
    class Task1
    {
        // Дано n дійсних чисел: n x1, x2,..., xn. Знайти середнє геометричне значення цих чисел
        public static void doTask()
        {
            Console.WriteLine("Завдання 1.1. Дано n дійсних чисел: n x1, x2,..., xn." +
                "Знайти середнє геометричне значення цих чисел.");

            double[] arr;

            Console.WriteLine("Обереть варіант заповнення масиву:" +
                    "\n 1 - Вручну" +
                    "\n 2 - Випадковими числами");
            int choice = Input.inputInt(1, 2, "Оберіть один із варіантів!", false);
            switch (choice)
            {
                case 1:
                    arr = Program.fillArray(positive: true);
                    break;
                case 2:
                    arr = Program.fillRandomArray(positive: true);
                    break;
                default:
                    arr = new double[1];
                    break;
            }

            double geomMean = getGeomMean(arr);
            Console.WriteLine("Середнє геометричне заданих чисел = " + Math.Round(geomMean, 5));
        }

        public static double getGeomMean(double[] arr)
        {
            double product = 1;
            foreach (double item in arr)
            {
                product *= item;
            }
            return Math.Pow(product, (double)1/arr.Length);
        }
    }
}
