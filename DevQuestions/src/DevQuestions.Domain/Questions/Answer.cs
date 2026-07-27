namespace DevQuestions.Domain.Questions;

public class Answer
{
    /*public Answer(Guid userid, string text, Question question)
    {
        Userid = userid;
        Text = text;
        Question = question;
    }*/
    
    public Guid Id { get; set; }
    public required Guid Userid { get; set; }
    public required string Text { get; set; }
    public required Question Question { get; set; }
    public List<Guid> Comments { get; set; } = [];

}