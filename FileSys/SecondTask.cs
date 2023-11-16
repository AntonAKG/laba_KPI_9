using System.Text.RegularExpressions;
using System.IO;

namespace FileSys;

public class SecondTask
{
    public void Second()
    {
        
        string text = File.ReadAllText("D:\\csharp_projects\\FileSys\\FileSys\\file_1.txt");

        int numberSpace = CountSpace(text);

        string longestWord = FindLongestWord(text);
        
        CreateDirectory(longestWord, numberSpace);
        
        Console.WriteLine(numberSpace);
        
        Console.WriteLine(longestWord);
    }

    static int CountSpace(string text)
    {
        int resultSpace = 0;
        
        foreach (var letter in text)
        {
            if (letter == ' ')
            {
                resultSpace += 1;
            }
        }

        return resultSpace;
    }

    static string FindLongestWord(string text)
    {
        string longestWord = "";
        
        MatchCollection matches = Regex.Matches(text, @"\w+");
        
        foreach (var match in matches)
        {
            string currentWord = match.ToString();
            
            if (currentWord.Length > longestWord.Length)
            {
                longestWord = currentWord;
            }
        }


        return longestWord;
    }

    static void CreateDirectory(string name, int lenght)
    
    {

        string path = $"D:\\csharp_projects\\FileSys\\{name}";

        if (!Directory.Exists(path))
        {
            DirectoryInfo di = Directory.CreateDirectory(path);
            Console.WriteLine("folder successfully created");
        }

        for (int i = 0; i < lenght; i++)
        {
            string filepath = $"D:\\csharp_projects\\FileSys\\{name}\\fl_{i}";

            using (FileStream fs = File.Create(filepath))
            {
                
            }
        }
    }
    
    
}