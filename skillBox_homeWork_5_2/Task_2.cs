namespace skillBox_homeWork_5_2
{
    internal class Task_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите строку которую надо перевернуть\n");
            string inputPhrase = Console.ReadLine();
            if (!String.IsNullOrEmpty(inputPhrase))
            {
                ReversWords(inputPhrase); 
               
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
        /// <описание>
        /// Разделяет фразу на слова, переворачивает и выводит на экран в перевёрнутом виде
        /// </описание>
        /// <param name="inputPhrase">Входная фраза</param>
        static void ReversWords(string inputPhrase) {

            string[] substrings = StringToArrayOfSubstrings(inputPhrase, " ");
            PrintReplacePhrase(substrings);

        }

        /// <описание>
        /// Изменяет порядок элементов в одномерном массиве и выводит на экран
        /// </описание>
        /// <param name="substrings">Массив строк</param>
        static void PrintReplacePhrase(string[] substrings)
        {
            string replacedPhrase = "";

            Array.Reverse(substrings);

            foreach (string item in substrings)
            {
                replacedPhrase += $"{item} ";
            }
                                 
             Console.Write(replacedPhrase.Trim());
        }

    }
}