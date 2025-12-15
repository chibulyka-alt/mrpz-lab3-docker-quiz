using QuizGame;

var quiz = new Quiz(pointsPerCorrect: 10);

Console.WriteLine("=== Quiz demo (Lab 3) ===");
Console.WriteLine($"Score: {quiz.Score}, Correct: {quiz.CorrectAnswers}, Total: {quiz.TotalAnswers}, Accuracy: {quiz.AccuracyPercent:0.##}%");

quiz.Answer(true);
quiz.Answer(false);
quiz.Answer(true);

Console.WriteLine("After answers:");
Console.WriteLine($"Score: {quiz.Score}, Correct: {quiz.CorrectAnswers}, Total: {quiz.TotalAnswers}, Accuracy: {quiz.AccuracyPercent:0.##}%");

quiz.Reset();

Console.WriteLine("After reset:");
Console.WriteLine($"Score: {quiz.Score}, Correct: {quiz.CorrectAnswers}, Total: {quiz.TotalAnswers}, Accuracy: {quiz.AccuracyPercent:0.##}%");
