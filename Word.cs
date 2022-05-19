// summary: Holds value of the word, checks guesses, and updates guesses word value
class Word
{
   Random _random = new Random();
   string _word;
   string[] _wordList = {"hello", "world", "cse210", "jumper"};
   char[] _wordArray;



   // summary: Constructor initializes the word for the game
   public Word()
   {
      _word = _wordList[_random.Next(_wordList.Length + 1)];
      _wordArray = _word.ToCharArray();
   }



   /*
   summary: Checks if a letter if found in the word
   param: (string guess) the letter guessed by the user
   return: (bool) returns if the guess was correct or not
   */
   public bool CheckGuess(string guess, string word)
   {
      bool correctGuess = false;
      for (int i = 0; i < _wordArray.Length; i++)
      {
         if (guess.Equals(_wordArray[i]))
         {
            correctGuess = true;
         }
      }
      return correctGuess;
   }



   /*
   summary: Adds a correct guess into the incomplete word
   param: (string word) the word being guesses by the jumper | (string guess) the letter that was guessed
   return: (string) The guessed word with the added letters
   */
   public string AddLetter(string word, string guess)
   {
      char[] guessArray = word.ToCharArray();
      for (int i = 0; i < _wordArray.Length; i++)
      {
         if (guess.Equals(_wordArray[i]))
         {
            guessArray[i * 2] = Convert.ToChar(guess);
         }
      }
      string updatedWord = new string(guessArray);
      return updatedWord;
   }



   /*
   summary: Create empty guess word
   return: (string) dashed string with a space between each dash. 
   */
   public string EmptyWord()
   {
      string guessWord = String.Empty;
      for (int i = 0; i < _wordArray.Length; i++){
         if (i == _wordArray.Length - 1)
         {
            guessWord += "_";
            break;
         }
         guessWord += "_ ";
      }
      return guessWord;
   }
}