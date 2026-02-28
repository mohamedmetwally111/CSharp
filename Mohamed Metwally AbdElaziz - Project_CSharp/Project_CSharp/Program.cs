namespace Project_CSharp;

internal class Program
{
    static void Main()
    {
        Subject math = new Subject(747664, "Math");

        PracticeExam practice = new PracticeExam(60, 10, math);

        FinalExam final = new FinalExam(60, 10, math);

        TrueOrFalseQuetion q1 = new TrueOrFalseQuetion("The Sun rises from the East", 5);
        practice.quetions.Add(q1);
        practice.correcttAnswer.Add(q1, q1.Answers[0]);

        final.quetions.Add(q1);
        final.correcttAnswer.Add(q1, q1.Answers[0]);

        ChoiseOneQuetion q2 = new ChoiseOneQuetion("Which planet is known as the Red Planet?", 5);
        q2.Answers.Add(new Answer("Earth"));
        q2.Answers.Add(new Answer("Mars"));
        q2.Answers.Add(new Answer("Jupiter"));
        q2.Answers.Add(new Answer("Venus"));
        practice.quetions.Add(q2);
        practice.correcttAnswer.Add(q2, q2.Answers[1]);

        final.quetions.Add(q2);
        final.correcttAnswer.Add(q2, q2.Answers[1]);

        ChoiseAllQuetion q3 = new ChoiseAllQuetion("Select prime numbers:", 5);
        q3.Answers.Add(new Answer("2"));
        q3.Answers.Add(new Answer("6"));
        q3.Answers.Add(new Answer("4"));
        q3.Answers.Add(new Answer("8"));
        practice.quetions.Add(q3);
        practice.correcttAnswer.Add(q3, q3.Answers[0]);

        final.quetions.Add(q3);
        final.correcttAnswer.Add(q3, q3.Answers[0]);


        int input;
        do
        {
            Console.Write("Select Exam Type: 1.Practice   2.Final :");

        }
        while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > 2);

        if (input == 1)
        {
            Console.WriteLine($"--- Practice Exam: {practice.subject.Name} ---\n");
            practice.ShowExam();
        }
        else if (input == 2)
        {
            Console.WriteLine($"--- Final Exam: {final.subject.Name} ---\n");
            final.ShowExam();
        }

    }

}