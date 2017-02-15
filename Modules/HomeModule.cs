using Nancy;
using System.Collections.Generic;
using FindAndReplace.Objects;

namespace FindAndReplace
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };

            Post["/result"] = _ => {
                string sentence = Request.Form["sentence"];
                string wordSelect = Request.Form["word"];
                string wordReplace = Request.Form["replacement-word"];
                Replace newReplace = new Replace(sentence, wordSelect, wordReplace);
                string newSentence = newReplace.ReplaceWord();
                return View["index.cshtml", newSentence];
            };
        }
    }
}
