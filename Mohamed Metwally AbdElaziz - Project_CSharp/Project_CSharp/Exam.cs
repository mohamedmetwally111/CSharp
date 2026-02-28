using System;
using System.Collections.Generic;
using System.Text;

namespace Project_CSharp
{
    enum ExamMode { Starting, Queued, Finished }

    #region Exam class
    internal abstract class Exam : ICloneable, IComparable<Exam>
    {
        public int Time { get; set; }

        public Subject subject { get; set; }
        public int NumberOfQuetion { get; set; }
        public Dictionary<Quetion, Answer> correcttAnswer { get; set; }
        public ExamMode mode { get; set; }
        public QuetionList quetions { get; set; }

        protected Exam(int _Time, int _NumberOfQuetion, Subject _subject)
        {
            Time = _Time;
            NumberOfQuetion = _NumberOfQuetion;
            correcttAnswer = new Dictionary<Quetion, Answer>();
            quetions = new QuetionList("exam.txt");
            mode = ExamMode.Queued;
            subject = _subject;
        }

        public abstract void ShowExam();

        public abstract object Clone();


        public int CompareTo(Exam? other)
        {
            if (this.Time > other.Time)
                return 1;
            else if (this.Time < other.Time)
                return -1;
            else
                return 0;

        }

        public override string ToString()
        {
            return $"Exam: {subject.Name}, Quetions:{NumberOfQuetion}, Time:{Time} mins, mode:{mode}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Exam other)
            {
                return this.Time == other.Time &&
                    this.NumberOfQuetion == other.NumberOfQuetion &&
                    this.subject.Name == other.subject.Name;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(NumberOfQuetion, subject.Name, Time);
        }
    }

    #endregion

    #region class Subject
    class Subject
    {
        public int Code { get; set; }
        public string Name { get; set; }

        public Subject(int _Code, string _Name)
        {
            Code = _Code;
            Name = _Name;
        }

    }
    #endregion

    #region class PracticeExam
    class PracticeExam : Exam
    {

        public PracticeExam(int _Time, int _NumberOfQuetion, Subject _subject) : base(_Time, _NumberOfQuetion, _subject)
        {

        }

        public override object Clone()
        {
            return new PracticeExam(this.Time, this.NumberOfQuetion, this.subject);
        }

        public override void ShowExam()
        {
            int i = 1;

            Console.WriteLine($"Practice Exam - Subject: {subject.Name} - Time: {Time} minutes");
            Console.WriteLine();

            foreach (var v in quetions)
            {
                v.ShowQuetion();


                int choice;


                do
                {

                    Console.WriteLine("Enter Correct Answer");

                }
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > v.Answers.Count);


                Answer stuanswer = v.Answers[choice - 1];
                Console.WriteLine($"Your answer: {stuanswer.Text}");

                if (stuanswer.Text == correcttAnswer[v].Text)
                    Console.WriteLine("Correct\n");
                else
                    Console.WriteLine($"Wrong! Correct answer is: {correcttAnswer[v].Text}\n");
            }

        }
    }
    #endregion

    #region class FinalExam
    class FinalExam : Exam
    {
        public FinalExam(int _Time, int _NumberOfQuetion, Subject _subject) : base(_Time, _NumberOfQuetion, _subject)
        {

        }

        public override object Clone()
        {
            return new FinalExam(this.Time, this.NumberOfQuetion, this.subject);
        }

        public override void ShowExam()
        {
            Console.WriteLine($"Final Exam - Subject: {subject.Name} - Time: {Time} minutes");
            Console.WriteLine();

            int i = 1;

            foreach (var v in quetions)
            {
                v.ShowQuetion();
                Console.WriteLine();
            }

        }
    }
    #endregion
}
