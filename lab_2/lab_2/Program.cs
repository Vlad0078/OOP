using System;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            while (true)
            {
                Console.WriteLine("Оберіть номер завдання" +
                    "\n 1 - Завдання 1.1" +
                    "\n 2 - Завдання 1.2" +
                    "\n 3 - Завдання 1.3" +
                    "\n 4 - Завдання 2.1" +
                    "\n 5 - Завдання 2.2" +
                    "\n 6 - Завдання 2.3" +
                    "\n 0 - Вихід");
                int choice = Input.inputInt(0, 6, "Оберіть один із варіантів!", false);
                Console.Clear();

                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Task1.doTask();
                        break;
                    case 2:
                        Task2.doTask();
                        break;
                    case 3:
                        Task3.doTask();
                        break;
                    case 4:
                        Task4.doTask();
                        break;
                    case 5:
                        Task5.doTask();
                        break;
                    case 6:
                        Task6.doTask();
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        // заповнення масивів
        public static double[] fillArray(string dimention_message = "Введіть розмірність масиву",
            string start_input_message = "Введіть числа", string element_name = "Число", bool positive = false)
        {
            Console.WriteLine(dimention_message);
            int n = Input.inputInt(min: 1, message: "Введіть натуральне число!", clearConsole: false);
            double[] arr = new double[n];
            Console.WriteLine(start_input_message);
            for (int i = 0; i < n; i++)
            {
                Console.Write(element_name + " " + (i + 1) + ": ");
                arr[i] = Input.inputDouble(min: positive?0:Double.MinValue, message: "Введіть " +
                    (positive ? "невід'ємне " : "") + "дійсне число", clearConsole: false);
            }

            return arr;
        }

        public static double[] fillRandomArray(string dimention_message = "Введіть розмірність масиву",
            bool show_generated = true, string shown_name = "Згенерований масив", bool positive = false)
        {
            Console.WriteLine(dimention_message);
            int n = Input.inputInt(min: 1, message: "Введіть натуральне число!", clearConsole: false);
            Console.WriteLine("Введіть мінімальне значення");

            int min = Input.inputInt(min: (positive ? 0 : Int32.MinValue), message: "Введіть " +
                (positive?"натуральне":"ціле") + " число!", clearConsole: false);
            Console.WriteLine("Введіть максимальне значення");
            int max = Input.inputInt(min: (positive ? min : Int32.MinValue), message: "Введіть " + (positive ?
                "натуральне" : "ціле") + " число, не менше за мінімальне значення!", clearConsole: false);

            double[] arr = new double[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(min, max + 1);
            }
            if (show_generated)
            {
                Console.Write(shown_name + ": [");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + (i != n - 1 ? "; " : "]"));
                }
                Console.WriteLine();
            }
            return arr;
        }

        // сортування масивів
        public static void myInsertionSort(double[] arr, bool desc = false)
        {
            int index;
            double curr;

            for (int i = 0; i < arr.Length; i++)
            {
                index = i;
                curr = arr[i];
                while(index > 0 && (desc ? curr > arr[index - 1] : curr < arr[index - 1]))
                {
                    arr[index] = arr[index - 1];
                    index--;
                }
                arr[index] = curr;
            }
        }

        // заповнення матриць
        public static int[,] fillMatrix(bool sqr = false)
        {
            int n, m;
            if (sqr)
            {
                Console.WriteLine("Введіть розмірність матриці");
                n = Input.inputInt(min: 1, message: "Введіть натуральне число!", clearConsole: false);
                m = n;
            }
            else
            {
                Console.WriteLine("Введіть кількість рядків");
                n = Input.inputInt(min: 1, message: "Введіть натуральне число!", clearConsole: false);
                Console.WriteLine("Введіть кількість стовпців");
                m = Input.inputInt(min: 1, message: "Введіть натуральне число!", clearConsole: false);
            }

            int[,] matrix = new int[n, m];

            Console.WriteLine("Введіть числа");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("a" + (i + 1) + "" + (j + 1) + " = ");
                    matrix[i, j] = Input.inputInt(message: "Введіть ціле число", clearConsole: false);
                }
            }
            return matrix;
        }

        public static int[,] fillRandomMatrix(bool sqr = false)
        {
            int n, m;
            if (sqr)
            {
                Console.WriteLine("Введіть розмірність матриці");
                n = Input.inputInt(min: 1, message: "Введіть натуральне число!", clearConsole: false);
                m = n;
            }
            else
            {
                Console.WriteLine("Введіть кількість рядків");
                n = Input.inputInt(min: 1, message: "Введіть натуральне число!", clearConsole: false);
                Console.WriteLine("Введіть кількість стовпців");
                m = Input.inputInt(min: 1, message: "Введіть натуральне число!", clearConsole: false);
            }

            Console.WriteLine("Введіть мінімальне значення");

            int min = Input.inputInt(message: "Введіть ціле число!", clearConsole: false);
            Console.WriteLine("Введіть максимальне значення");
            int max = Input.inputInt(min: min, message: "Введіть ціле число, не менше за мінімальне значення!",
                clearConsole: false);

            int[,] matrix = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i,j] = rnd.Next(min, max + 1);
                }
            }
            return matrix;
        }

        public static void showMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
