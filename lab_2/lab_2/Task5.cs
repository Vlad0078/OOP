using System;

namespace lab_2
{
    class Task5
    {
        // Дана цілочислова прямокутна матриця. Визначити кількість стовпців, які не містять
        // жодного нульового елемента.

        public static void doTask()
        {
            Console.WriteLine("Завдання 2.2. Дана цілочислова прямокутна матриця. Визначити кількість " +
                "стовпців, які не містять жодного нульового елемента.");

            int[,] matrix;

            Console.WriteLine("Обереть варіант заповнення масиву:" +
                    "\n 1 - Вручну" +
                    "\n 2 - Випадковими числами");
            int choice = Input.inputInt(1, 2, "Оберіть один із варіантів!", false);
            switch (choice)
            {
                case 1:
                    matrix = Program.fillMatrix();
                    break;
                case 2:
                    matrix = Program.fillRandomMatrix();
                    break;
                default:
                    matrix = new int[1, 1];
                    break;
            }

            Console.WriteLine("Матриця:");
            Program.showMatrix(matrix);

            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int nonzero_cols = m;

            // підрахунок
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if(matrix[i,j] == 0)
                    {
                        nonzero_cols--;
                        break;
                    }
                }
            }

            Console.WriteLine("\nКількість стовпців, які не містять жодного нульового елемента: " +
                nonzero_cols);
        }
    }
}
