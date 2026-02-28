using System;
using System.Collections.Generic;
using System.Text;

namespace Project_CSharp
{
    
        #region Class Question
        internal abstract class Quetion
        {
            public string Body { get; set; }

            public string Header { get; set; }

            public int Marks { get; set; }

            public AnswerList Answers { get; set; }

            public Quetion(string _Header, string _Body, int _Marks)
            {
                Body = _Body;
                Header = _Header;
                Marks = _Marks;
                Answers = new AnswerList();


            }

            public abstract void ShowQuetion();


        }
        #endregion

        #region question List
        class QuetionList : List<Quetion>
        {
            private string logFile;
            public QuetionList(string file_name)
            {
                logFile = file_name;
            }

            public new void Add(Quetion q)
            {
                base.Add(q);
                using (StreamWriter sw = new StreamWriter(logFile, true))
                {
                    sw.WriteLine($"{q.Header}: {q.Body}");
                }
            }
        }
        #endregion

        #region class TrueOrFalseQuetion
        class TrueOrFalseQuetion : Quetion
        {
            public TrueOrFalseQuetion(string _Body, int _Marks) : base("True/False", _Body, _Marks)
            {
                Answers.Add(new Answer("True"));
                Answers.Add(new Answer("False"));

            }

            public override void ShowQuetion()
            {
                Console.WriteLine($"{Header}\n{Body}");
                int i = 1;
                foreach (var v in Answers)
                {
                    Console.WriteLine($" {i}. {v.Text}");
                    i++;
                }
            }

        }
        #endregion

        #region class ChoiseOneQuetion
        class ChoiseOneQuetion : Quetion
        {
            public ChoiseOneQuetion(string _Body, int _Marks) : base("Choose One", _Body, _Marks)
            {
                Answers = new AnswerList();
            }

            public override void ShowQuetion()
            {
                Console.WriteLine($"{Header}\n{Body}");
                int i = 1;
                foreach (var ans in Answers)
                {
                    Console.WriteLine($" {i}. {ans.Text}");
                    i++;
                }
            }
        }
        #endregion

        #region  class ChoiseAllQuetion
        class ChoiseAllQuetion : Quetion
        {
            public ChoiseAllQuetion(string _Body, int _Marks) : base("Choose All", _Body, _Marks)
            {
                Answers = new AnswerList();
            }

            public override void ShowQuetion()
            {
                Console.WriteLine($"{Header}\n{Body}");
                int i = 1;
                foreach (var ans in Answers)
                {
                    Console.WriteLine($"{i}. {ans.Text}");
                    i++;
                }

            }
        }
        #endregion
}

