using System;

namespace lab_2
{
    class Task3
    {
        // Впорядкувати елементи масиву за спаданням.
        public static void doTask()
        {
            Console.WriteLine("Завдання 1.3. Впорядкувати елементи масиву за спаданням.");

            double[] arr;

            Console.WriteLine("Обереть варіант заповнення масиву:" +
                    "\n 1 - Вручну" +
                    "\n 2 - Випадковими числами");
            int choice = Input.inputInt(1, 2, "Оберіть один із варіантів!", false);
            switch (choice)
            {
                case 1:
                    arr = Program.fillArray();
                    break;
                case 2:
                    arr = Program.fillRandomArray();
                    break;
                default:
                    arr = new double[1];
                    break;
            }
            Program.myInsertionSort(arr, true);
            Console.Write("Відсортований масив: {");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + (i != arr.Length - 1 ? "; " : "}"));
            }
        }
    }
}
