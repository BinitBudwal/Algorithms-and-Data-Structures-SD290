//Question_1 => bool IsPalindrome( string testString ) returns whether or not a word can be read the same way, forward and backwards.

using System.Text;

string inputString = "racecar";

bool IsPalindrone(string inputString)
{
    StringBuilder sb = new StringBuilder();

    for (int i = inputString.Length - 1; i >= 0; i--)
    {
        sb.Append(inputString[i]);
    }
    return inputString == sb.ToString();
}

Console.WriteLine($"Is {inputString} Palindrome? \n{IsPalindrone(inputString)}");


//Question_2 => char[] DuplicateCharacters( string testString ) returns an array of all characters that appear more than once in a string. 

//string inputString = "Programmatic Python";

//string toLowerCase = inputString.ToLower();


//char[] DuplicateCharacters(string inputString)
//{

//}



//Bonus Question =>String[] UniqueWords(string testString) returns an array of strings that are unique words found in the argument.


string inputString2 = "To be or not to be To be or not to be";

string toLowerCase = inputString2.ToLower();

string[] UniqueWords(string inputString2)
{
    string[] stringsArray = inputString2.Split(' ');
    string[] distinctWords = stringsArray.Distinct().ToArray();

    return distinctWords;

}

foreach (string words in UniqueWords(toLowerCase))
{
    Console.WriteLine(words);
}
