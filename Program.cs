while (true)
{
    Console.WriteLine("Please enter a word");

    string input = Console.ReadLine().ToLower();

    // char[] chars = new char [] { 'a', 'e', 'i', 'o', 'u' }; keeping this here for now 

    char first = input[0];

    int vowelPosition = -1; // keeping track of where my first vowel is; starting at -1 so it gets to 0 with first loop through
    string newStart = ""; // first letters of the new word 
    string moveThis = ""; // the chunk of letters i need to move 



    if (first == 'a' || first == 'e' || first == 'i' || first == 'o' || first == 'u')
    {
        Console.WriteLine(input + "way");
    }

    else // starts with consonant     
    {
        foreach (char letter in input)
        {
            vowelPosition++;
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                moveThis = input.Substring(0, vowelPosition); // saves the letters to be moved as its own string 

                int remainingLetters = (input.Length - moveThis.Length); // to make sure all remaining letters are accounted for after I substring out "move this"

                newStart = input.Substring(vowelPosition, remainingLetters); // this starts at vowel position, and takes all remaining letters as rest of substring

                Console.WriteLine(newStart + moveThis + "ay");
                break; // exit the loop once we find the first vowel 
            }


        }
    }

    Console.WriteLine("Do you want to translate another word? y/n ");
    string restart = Console.ReadLine().ToLower();
    if (restart == "yes" || restart == "y")
    {
        continue;
    }
    else
    {
        Console.WriteLine("thanks for playing");
        break;
    }
}

// if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'o')