Console.Write("Please enter a Number:");

int integer = Int32.Parse(Console.ReadLine());

Console.Write($"\nPlease enter {integer} words: \n");


string[] wordsArray = new string[integer];
for (int i = 0; i < wordsArray.Length; i++)
{
    wordsArray[i] = Console.ReadLine();
    string s = wordsArray[i] ;
    bool hasSpace = s.Contains(" ");
    if (hasSpace == true)
    {
        //if this condition runs it breaks the code.
        Console.WriteLine("Yor word contains space run the program again");
        break;

    }
}

Console.WriteLine("\n Please enter a character:");

char character = Console.ReadKey().KeyChar;
char lowerCharacter = char.ToLower(character);

int counter = 0;
int totalCharacters = 0;

for (int i = 0; i < wordsArray.Length; i++)
{
    for (int j = 0; j < wordsArray[i].Length; j++)
    {
        if (wordsArray[i][j] == lowerCharacter)
        {
            counter++;

        }
        totalCharacters++;
    }


}

double twentyFivePercent = 0.25 * totalCharacters;

if (counter > twentyFivePercent)
{
    Console.WriteLine($"\n The letter '{lowerCharacter}'appears {counter} times in the array.. This letter makes up more than 25% of the total number of characters.");
}
else
{
    Console.WriteLine($"\n The letter '{lowerCharacter}'appears {counter} times in the array. ");
}
