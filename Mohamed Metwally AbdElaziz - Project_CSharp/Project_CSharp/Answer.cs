using System;
using System.Collections.Generic;
using System.Text;

namespace Project_CSharp
{
    #region class Answer
    internal class Answer
    {
        public string Text { get; set; }

        public Answer(string _Text)
        {
            Text = _Text;

        }

        public override string ToString()
        {
            return Text;
        }
    }
    #endregion

    #region class AnswerList
    class AnswerList : List<Answer>
    {

    }
    #endregion
}
