namespace Examination_System;

public enum QuestionType
{
    TrueOrFalse,
    Mcq
}

public class Question
{
    public string Header { get; set; }
    public string Body { get; set; }
    public decimal Mark { get; set; }

    public List<Answer> Answers { get; set; }
    public Answer RightAnswer { get; set; }
    
}