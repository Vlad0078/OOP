using System;

namespace lab_2
{
    class Input
    {
        private const string defaultMessage = "Помилка вводу. Повторіть спробу";


        /// <summary>
        /// Ввід цілого числа
        /// </summary>
        /// <param name="message">Повідомлення при помилці</param>
        /// <param name="clearConsole">Очищає консоль якщо true</param>
        /// <param name="newLine">Перехід на наступну стрічку після повідомлення про помилку</param>
        /// <returns>Число типу Int32</returns>
        public static int inputInt(int min = Int32.MinValue, int max = Int32.MaxValue,
            string message = defaultMessage, bool clearConsole = true, bool newLine = true)
        {
            bool flag;
            string strInput;
            int input;
            do
            {
                strInput = Console.ReadLine();
                flag = Int32.TryParse(strInput, out input);
                if (flag)
                    if (input < min || input > max)
                        flag = false;
                if (!flag)
                {
                    if (clearConsole)
                        Console.Clear();
                    if (newLine)
                        Console.WriteLine(message);
                    else
                        Console.Write(message);
                }
            }
            while (!flag);
            return input;
        }


        /// <summary>
        /// Ввід раціонального числа
        /// </summary>
        /// <param name="message">Повідомлення при помилці</param>
        /// <param name="clearConsole">Очищає консоль якщо true</param>
        /// /// <param name="newLine">Перехід на наступну стрічку після повідомлення про помилку</param>
        /// <returns>Число типу Double</returns>
        public static double inputDouble(double min = Double.MinValue, double max = Double.MaxValue,
            string message = defaultMessage, bool clearConsole = true, bool newLine = true)
        {
            bool flag;
            string strInput;
            double input;
            do
            {
                strInput = Console.ReadLine().Replace(',', '.');
                flag = Double.TryParse(strInput, out input);
                if (flag)
                    if (input < min || input > max)
                        flag = false;
                if (!flag)
                {
                    if (clearConsole)
                        Console.Clear();
                    if (newLine)
                        Console.WriteLine(message);
                    else
                        Console.Write(message);
                }
            }
            while (!flag);
            return input;
        }
    }
}
