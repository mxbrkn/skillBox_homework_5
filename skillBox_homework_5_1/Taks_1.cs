using System;

namespace skillBox_homework_5_1
{
    internal class Taks_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите строку которую надо разделить\n");
            string sentense = Console.ReadLine();
            if (!String.IsNullOrEmpty(sentense)) {
                string[] substrings = StringToArrayOfSubstrings(sentense, " ");
                PrintArrayElements(substrings);
            };
            

        }
        /// <summary>
        /// Раскладывает строку в массив подстрок
        /// </summary>
        /// <param name="sentense">Строка которуд надо разделить</param>
        /// <param name="splitter">Разделитель - строка символ который является отсечкой</param>
        /// <returns>Вовзращает массив элементов с типом строка</returns>
        static string[] StringToArrayOfSubstrings(string sentense, string splitter)
        {
            return sentense.Split(splitter);
        }

        /// <summary>
        /// Выводит на экран каждый элемент строкового массива с новой строки
        /// </summary>
        /// <param name="substrings">Аргумент должен быть массивом из строк</param>
        static void PrintArrayElements(string[] substrings)
        {
            foreach (string item in substrings)
            {
                Console.WriteLine   (item);
            }
        }
    }
}