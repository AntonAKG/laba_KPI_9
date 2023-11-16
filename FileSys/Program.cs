namespace FileSys;

class Program
{
    static void Main()
    {
        FindWordInFile findWord = new FindWordInFile();
        SecondTask secondTask = new SecondTask();

        findWord.FindWord();
        secondTask.Second();
    }
}