// summary: 
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
   param: (string word) the word being guesses by the jumper
   return: (string) The guessed word with the added correct letters
   */
   public string AddLetter(string word)
   {
      
   }
}