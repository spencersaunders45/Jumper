// summary: 

class SkyDiver
{
   private int _wrongGuesses;
   public SkyDiver()
   {
      _wrongGuesses = 0;
   }



   /*
   summary: Shows the value of _wrongGuesses
   return: (int) the current number of _wrongGuesses
   */
   public int GetWrongGuesses()
   {
      return _wrongGuesses;
   }



   /*
   summary: Updates the value of _wrongGuesses
   */
   public void WrongGuess()
   {
      _wrongGuesses++;
   }



   /*
   summary: Updates if the game is over
   return: (bool) the state of the game
   */
   public bool CheckShoot(Word word)
   {
      if (word.WordLength() - 1 == _wrongGuesses)
      {
         return true;
      }
      else
      {
         return false;
      }
   }
}