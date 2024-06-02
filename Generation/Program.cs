namespace Generation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Empty method is used to create an empty sequence of a specified type

            var questions = Enumerable.Empty<Question>();

            // DefaultIfEmpty method in LINQ is used to provide a default value if a sequence is empty
            var defaultQuestions = questions.DefaultIfEmpty(Question.Default);

            defaultQuestions.ToQuiz();

            Console.WriteLine("=============================================");
            // Range method in LINQ is used to generate a sequence of integers within a specified range
            var range = Enumerable.Range(0, 10);

            var rangeQuestions = QuestionBank.GetQuestionRange(range);
            rangeQuestions.ToQuiz();

            Console.WriteLine("=============================================");

            // Repeat method in LINQ is used to generate a sequence that contains one repeated value a specified number of times.
            var question = QuestionBank.PickOne();
            var repeatedQuestions = Enumerable.Repeat(question, 10);
            repeatedQuestions.ToQuiz();

        }
    }

}
