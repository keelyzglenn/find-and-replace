using System;
using System.Collections.Generic;
using System.Linq;

namespace FindAndReplace.Objects
{
  public class Replace
  {
      private string _sentence;
      private string _wordSelect;
      private string _replacementWord;
      private string[] _sentenceSplitArray;

      public Replace(string sentence, string wordSelect, string replacementWord)
      {
         _sentence = sentence;
         _wordSelect = wordSelect;
         _replacementWord = replacementWord;
         _sentenceSplitArray = sentence.Split(' ');
      }

      public string[] GetSentenceSplitArray()
      {
          return _sentenceSplitArray;
      }

      public List<string> CompareWords()
      {
          List<string> matchingWords = new List<string>{};
          foreach (string word in _sentenceSplitArray) {
              if(word == _wordSelect)
              {
                  matchingWords.Add(word);

              }
          }
          return matchingWords;
      }

      public string ReplaceWord()
      {
          string replacementString = "";
          foreach (string word in _sentenceSplitArray) {
              if(word.ToLower().Contains(_wordSelect.ToLower()))
              {

                  if(word.Any(char.IsUpper))
                  {
                      replacementString += _replacementWord.First().ToString().ToUpper() + String.Join("", _replacementWord.Skip(1)) + String.Join("", word.Skip(_wordSelect.Length))+ " ";

                  }
                  else
                  {
                      replacementString += _replacementWord + String.Join("", word.Skip(_wordSelect.Length)) + " ";
                  }
              }
              else
              {
                  replacementString += word + " ";
              }
          }
          return replacementString;
      }
  }
}
