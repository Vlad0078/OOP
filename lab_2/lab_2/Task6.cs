using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class Task6
    {
        // Дана цілочислова прямокутна матриця. Переставляючи рядки даної матриці, розташувати
        // їх у відповідності з ростом характеристик.Характеристикою рядка цілочислової матриці
        // назвемо суму її додатних парних елементів.

        public static void doTask()
        {
            Console.WriteLine("Завдання 2.3. Дана цілочислова прямокутна матриця. Переставляючи рядки " +
                "даної матриці, розташувати їх у відповідності з ростом характеристик. Характеристикою " +
                "рядка цілочислової матриці назвемо суму її додатних парних елементів.");

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

            Console.WriteLine("Початкова матриця:");
            Program.showMatrix(matrix);

            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int[] characteristics = new int[n];

            // розрахунок "характеристик"
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(matrix[i,j] > 0 && matrix[i, j]%2 == 0)
                    {
                        characteristics[i] += matrix[i, j];
                    }
                }
            }

            Console.WriteLine("\nХарактеристики рядків: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Рядок " + (i + 1) + " - " + characteristics[i]);
            }

            // сортування
            int index;
            int curr_ch;
            int[] curr_row = new int[m];

            for (int i = 0; i < n; i++)
            {
                index = i;
                curr_ch = characteristics[i];
                copyRowToArray(curr_row, matrix, i);

                while (index > 0 && curr_ch < characteristics[index - 1])
                {
                    // Помилка! Дубляж!
                    characteristics[index] = characteristics[index - 1];
                    copyRowToRow(matrix, index - 1, index);
                    index--;
                }
                characteristics[index] = curr_ch;
                copyRowToArray(curr_row, matrix, index, true);
            }

            Console.WriteLine("\nМатриця після перетворень:");
            Program.showMatrix(matrix);
        }

        /// <summary>
        /// Скопіювати рядок матриці в масив
        /// </summary>
        public static void copyRowToArray(int[] arr, int[,] matrix, int row_idx, bool arrayToRow = false)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arrayToRow)
                {
                    matrix[row_idx, i] = arr[i];
                }
                else
                {
                    arr[i] = matrix[row_idx, i];
                }
            }
        }

        /// <summary>
        /// Скопіювати один рядок матриці (row1) в інший (row2)
        /// </summary>
        public static void copyRowToRow(int[,] matrix, int row1_idx, int row2_idx)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[row2_idx, i] = matrix[row1_idx, i];
            }
        }
    }
}
