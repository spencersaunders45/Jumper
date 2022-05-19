//summary: 

class InOut
{
   List<string> _jumperImage;

   public InOut()
   {
      _jumperImage = new List<string>();
      CreateJumperImage();
   }



   // summary: addes string values to the List
   private void CreateJumperImage()
   {
      _jumperImage.Add(" ___ ");
      _jumperImage.Add("/___\\");
      _jumperImage.Add("\\   /");
      _jumperImage.Add(" \\ /");
      _jumperImage.Add("  0  ");
      _jumperImage.Add(" /|\\ ");
      _jumperImage.Add(" / \\ ");
   }



   /*
   summary: Chooses which jumper to display
   param: (SkyDiver skyDiver) an object of SkyDiver | (Word word) an object of Word
   */
   public void DisplayJumper(SkyDiver skyDiver, Word word)
   {
      int wrongGuesses = skyDiver.GetWrongGuesses();
      if (wrongGuesses == word.WordLength() - 1)
      {
         DeadJumper();
      }
      else
      {
         AliveJumper(wrongGuesses);
      }
   }



   /*
   summary: Displays the jumper when guesses remain
   param: (int wrongGuesses) the number of incorrect guesses
   */
   private void AliveJumper(int wrongGuesses)
   {
      for (int i = wrongGuesses; i < _jumperImage.Count; i++)
      {
         Console.WriteLine(_jumperImage[i]);
      }
      Console.Write("\n");
      Console.WriteLine("^^^^^^^");
   }



   /*
   summary: Displays the jumper when no guesses remain
   */
   private void DeadJumper()
   {
      Console.WriteLine("  x  ");
      Console.WriteLine(" /|\\ ");
      Console.WriteLine(" / \\ ");
      Console.Write("\n");
      Console.WriteLine("^^^^^^^");
   }



   /*
   summary: Gets the users guess
   return: (string) returns a single letter
   */
   public string GuessLetter()
   {
      string guess = String.Empty;
      do{
         Console.Write("Guess a letter [a-z]: ");
         guess = Console.ReadLine();
      } while (guess == null || guess.Length != 1);
      return guess;
   }



   /*
   summary: Displays the state of the current guesses word
   param: (string word) the guesses word
   */
   public void DisplayWord(string word)
   {
      Console.WriteLine(word);
      Console.WriteLine();
   }
}