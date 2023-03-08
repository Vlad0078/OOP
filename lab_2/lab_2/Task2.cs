using System;

namespace lab_2
{
    class Task2
    {
        // Дано вектор x є R^n і число a є R.Знайти добуток вектора на число.
        public static void doTask()
        {
            Console.WriteLine("Завдання 1.2. Дано вектор x є R^n і число a є R. " +
                "Знайти добуток вектора на число.");
            double[] x;
            Console.WriteLine("Обереть варіант заповнення вектора:" +
                    "\n 1 - Вручну" +
                    "\n 2 - Випадковими числами");
            int choice = Input.inputInt(1, 2, "Оберіть один із варіантів!", false);
            switch (choice)
            {
                case 1:
                    x = Program.fillArray("Введіть розмірність вектора", "Введіть координати вектора",
                "Координата"); ;
                    break;
                case 2:
                    x = Program.fillRandomArray("Введіть розмірність вектора", false);
                    break;
                default:
                    x = new double[1];
                    break;
            }

            Console.Write("Вектор: {");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + (i != x.Length - 1 ? "; " : "}"));
            }
            Console.WriteLine();

            Console.WriteLine("Введіть множник");
            double a = Input.inputDouble(message: "Введіть дійсне число!", clearConsole: false);


            Console.Write("Вектор після множення на " + a + ": {");
            for (int i = 0; i < x.Length; i++)
            {
                x[i] *= a;
                Console.Write(x[i] + (i != x.Length - 1 ? "; " : "}"));
            }
        }
    }
}
