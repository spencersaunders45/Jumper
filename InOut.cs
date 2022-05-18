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
   summary: Displays the state of the jumper
   param: the number of wrong guesses
   */
   public void DisplayJumper(int wrongGuesses)
   {
      for (int i = wrongGuesses; i < _jumperImage.Count - wrongGuesses; i++)
      {
         Console.WriteLine(_jumperImage[i]);
      }
      Console.Write("\n\n");
      Console.WriteLine("^^^^^^^");
   }

   /*
   summary: 
   param:
   */
   public string GuessLetter()
   {
      Console.Write("Guess a letter [a-z]: ");
      string guess = Console.ReadLine();
      return guess;
   }

   /*
   summary: Displays the partly or fully completed word
   param: the partly completed word
   */
   public void DisplayWord(string word)
   {
      Console.WriteLine(word);
   }
}