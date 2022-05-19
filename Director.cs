//summary: Contains the game loop and calls all needed classes and methods

class Director
{
   private string _guessWord;
   private bool _gameOver;
   private Word _word = new Word();
   private SkyDiver _skyDiver = new SkyDiver();
   private InOut _IO = new InOut();
   private string _guessLetter;

   public Director()
   {
      _guessWord = _word.EmptyWord();
      _gameOver = false;
      _guessLetter = string.Empty;
   }

   /*
   summary: Controls the game
   */
   public void StartGame()
   {
      _word.DisplayWord();
      while (_gameOver == false)
      {
         _IO.DisplayWord(_guessWord);
         _IO.DisplayJumper(_skyDiver, _word);
         _guessLetter = _IO.GuessLetter();
         CheckGuess();
         CheckGame();
      }
      _IO.DisplayWord(_guessWord);
      _IO.DisplayJumper(_skyDiver, _word);
   }



   /*
   summary: decides what method should be called
   */
   private void CheckGuess()
   {
   if (_word.CheckGuess(_guessLetter))
      {
         _guessWord = _word.AddLetter(_guessWord, _guessLetter);
      }
      else
      {
         _skyDiver.WrongGuess();
      }
   }



   /*
   summary: decides what method should be called to check if the game is over
   */
   private void CheckGame()
   {
   if (_skyDiver.CheckShoot(_word))
      {
         _gameOver = true;
      }
      else
      {
         _gameOver = _word.IsComplete(_guessWord);
      }
   }
}