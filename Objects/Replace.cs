using System;
using System.Collections.Generic;

namespace FindAndReplace.Objects
{
  public class Replace
  {
      private string _sentence;
      private string _wordSelect;
      private string _replacementWord;
      private string[] _sentenceSplitArray;

      public Replace(string sentence)
      {
         _sentence = sentence;
        //  _wordSelect = wordSelect;
        //  _replacementWord = replacementWord;
         _sentenceSplitArray = sentence.Split(' ');
      }

      public string[] GetSentenceSplitArray()
      {
          return _sentenceSplitArray;
      }
  }
}
