using Xunit;
using FindAndReplace.Objects;
using System;
using System.Collections.Generic;

namespace FindAndReplace
{
  public class ReplaceTest
  {
      [Fact]
      public void GetSentenceSplitArray_SplitSentenceIntoWords_Array()
      {
          //Arrange
          string sentence = "This sentence";
          Replace newReplace = new Replace(sentence);
          string[] sentenceSplitArray = new string[] {"This", "sentence"};
          //Act
          var result = newReplace.GetSentenceSplitArray();
          //Assert
          Assert.Equal(sentenceSplitArray, result);
      }
  }
}
