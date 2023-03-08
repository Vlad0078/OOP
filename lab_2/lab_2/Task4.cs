using System;

namespace lab_2
{
    class Task4
    {
        // Дана цілочислова квадратна матриця. Розмістити елементи непарних рядків у порядку зростання.
        public static void doTask()
        {
            Console.WriteLine("Завдання 2.1. Дана цілочислова квадратна матриця. " +
                "Розмістити елементи непарних рядків у порядку зростання.");

            int[,] matrix;

            Console.WriteLine("Обереть варіант заповнення масиву:" +
                    "\n 1 - Вручну" +
                    "\n 2 - Випадковими числами");
            int choice = Input.inputInt(1, 2, "Оберіть один із варіантів!", false);
            switch (choice)
            {
                case 1:
                    matrix = Program.fillMatrix(true);
                    break;
                case 2:
                    matrix = Program.fillRandomMatrix(true);
                    break;
                default:
                    matrix = new int[1,1];
                    break;
            }

            Console.WriteLine("Початкова матриця:");
            Program.showMatrix(matrix);

            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int index;
            int curr;

            // сортування
            for (int i = 0; i < n; i++)
            {
                if (i%2 == 0)
                {
                    for (int j = 0; j < m; j++)
                    {
                        index = j;
                        curr = matrix[i, j];
                        while (index > 0 && curr < matrix[i, index - 1])
                        {
                            matrix[i, index] = matrix[i, index - 1];
                            index--;
                        }
                        matrix[i, index] = curr;
                    }
                }
            }

            Console.WriteLine("\nМатриця після перетворень:");
            Program.showMatrix(matrix);
        }
    }
}
