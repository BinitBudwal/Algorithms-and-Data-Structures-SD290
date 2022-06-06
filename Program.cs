void Main()
{
    int GetNumberInput()
    {
        Console.Write("Please enter a Number:");

        int integer = Int32.Parse(Console.ReadLine());
        return integer;
    }

    int inputNumber = GetNumberInput();

    string[] PopulateWordArray()
    {
        Console.Write($"\nPlease enter {inputNumber} words: \n");
        string[] wordsArray = new string[inputNumber];
        for (int i = 0; i < wordsArray.Length; i++)
        {
            wordsArray[i] = Console.ReadLine();
            string s = wordsArray[i];
            bool hasSpace = s.Contains(" ");
            if (hasSpace == true)
            {
                //if this condition runs it breaks the code.
                Console.WriteLine("Yor word contains space run the program again");
                break;

            }
        }
        return wordsArray;
    }

    string[] stringsArray = PopulateWordArray();


    char getCharacterInput()
    {
        Console.WriteLine("\n Please enter a character:");

        char character = Console.ReadKey().KeyChar;
        char lowerCharacter = char.ToLower(character);
        return lowerCharacter;
    }

    char inputCharacter = getCharacterInput();

    (int, int) CountCharacter()
    {
        int counter = 0;
        int totalCharacters = 0;

        for (int i = 0; i < stringsArray.Length; i++)
        {
            for (int j = 0; j < stringsArray[i].Length; j++)
            {
                if (stringsArray[i][j] == inputCharacter)
                {
                    counter++;

                }
                totalCharacters++;
            }


        }
        return (counter, totalCharacters);
    }

    var counterCount = CountCharacter();
    //int totalCharacterCount = CountCharacter();

    double GetCharacterOccurrencePercentage()
    {
        double twentyFivePercent = 0.25 * counterCount.Item2;
        return twentyFivePercent;
    }

    double twentyFivePercentResult = GetCharacterOccurrencePercentage();

    void PrintResults()
    {
        if (counterCount.Item1 > twentyFivePercentResult)
        {
            Console.WriteLine($"\n The letter '{inputCharacter}'appears {counterCount.Item1} times in the array.. This letter makes up more than 25% of the total number of characters.");
        }
        else
        {
            Console.WriteLine($"\n The letter '{inputCharacter}'appears {counterCount.Item1} times in the array. ");
        }

    }
    PrintResults();
}
Main();