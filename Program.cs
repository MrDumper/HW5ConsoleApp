static string[] SplitText(string text)
{
    return text.Split(' ');
}

static void PrintText(string[] text)
{
    for(int i = 0; i < text.Length; i++)
    {
        Console.WriteLine(text[i]);
    }
}

static string Reverse(string text)
{
    string[] words = SplitText(text);
    string resultText = "";
    for(int i = 0; i < words.Length; i++)
    {
        resultText += words[words.Length - 1 - i] + " ";
    }
    return resultText;
}

Console.WriteLine("Введите предложение: ");
string text = Console.ReadLine();

string[] words = SplitText(text);
PrintText(words);
Console.ReadKey();

string reverseText = Reverse(text);
Console.WriteLine(reverseText);
Console.ReadKey();
