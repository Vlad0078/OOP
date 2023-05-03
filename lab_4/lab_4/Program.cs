using System;
using System.IO;
using System.Collections.Generic;

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            string fileInput = "";

            try
            {
                fileInput = File.ReadAllText("../../../../input.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("Помилка: " + e.Message);
                Environment.Exit(0);
            }

            Console.WriteLine(" Вміст текстового файлу: " + fileInput);

            char[] charArr = fileInput.ToCharArray();
            Console.WriteLine(" Кількість прописних літер, визначена з використанням " +
                "масиву символів: " + CountCapitals(charArr));

            List<char> charList = new List<char>(fileInput);
            Console.WriteLine(" Кількість прописних літер, визначена з використанням " +
                "списку List<char>: " + CountCapitals(charList));
            
            Console.ReadKey();
        }

        static int CountCapitals(IEnumerable<char> chars)
        {
            int upperCount = 0;
            foreach (char item in chars)
            {
                if (char.IsUpper(item))
                {
                    upperCount++;
                }
            }
            return upperCount;
        }
    }
}
