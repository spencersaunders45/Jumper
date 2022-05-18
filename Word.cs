// summary: 
class Word
{
   Random _random = new Random();
   string _word;
   string[] _wordList = {"hello", "world", "cse210", "jumper"};

   // summary: 
   public Word()
   {
      _word = _wordList[_random.Next(_wordList.Length)];
   }

   
}