using QuizGame;

Console.WriteLine("=== Lab 3: Quiz Demo Application ===");
Console.WriteLine();

var quiz = new Quiz(pointsPerCorrect: 10);

PrintState("Initial state", quiz);


quiz.Answer(true);  
quiz.Answer(false);  
quiz.Answer(true);  


PrintState("After answering questions", quiz);

quiz.Reset();

PrintState("After reset", quiz);

Console.WriteLine("Demo finished.");

static void PrintState(string title, Quiz quiz)
{
    Console.WriteLine(title);
    Console.WriteLine($"Score: {quiz.Score}");
    Console.WriteLine($"Correct answers: {quiz.CorrectAnswers}");
    Console.WriteLine($"Total answers: {quiz.TotalAnswers}");
    Console.WriteLine($"Accuracy: {quiz.AccuracyPercent:0.##}%");
    Console.WriteLine();
}
