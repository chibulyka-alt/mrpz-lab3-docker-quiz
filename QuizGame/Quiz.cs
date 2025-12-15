namespace QuizGame;

public class Quiz
{
    private readonly int _pointsPerCorrect;

    public int Score { get; private set; }
    public int CorrectAnswers { get; private set; }
    public int TotalAnswers { get; private set; }

    public double AccuracyPercent =>
        TotalAnswers == 0 ? 0.0 : (CorrectAnswers * 100.0) / TotalAnswers;

    public Quiz(int pointsPerCorrect)
    {
        if (pointsPerCorrect < 0)
            throw new ArgumentOutOfRangeException(nameof(pointsPerCorrect));

        _pointsPerCorrect = pointsPerCorrect;
        Reset();
    }

    public void Answer(bool correct)
    {
        TotalAnswers++;
        if (correct)
        {
            CorrectAnswers++;
            Score += _pointsPerCorrect;
        }
    }

    public void Reset()
    {
        Score = 0;
        CorrectAnswers = 0;
        TotalAnswers = 0;
    }
}
