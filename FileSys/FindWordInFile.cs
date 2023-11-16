using System.Text.RegularExpressions;

namespace FileSys;

public class FindWordInFile
// Знайти кількість слів у файлi. Слова розділені пробілами та знаками пунктуації.

{
    public void FindWord()
    {
        

        Console.WriteLine($"Count file_1: {CountWords("D:\\csharp_projects\\FileSys\\FileSys\\file_1.txt")}");
    }

    static int CountWords(string filePath)
    {
        try
        {
            string text = File.ReadAllText(filePath);

            MatchCollection matches = Regex.Matches(text, @"\w+");

            int wordCount = matches.Count;

            return wordCount;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
            return -1;
        }
    }

}