namespace Entities
{
    internal class Question(string questionContent)
    {
        public string QuestionContent { get; set; } = questionContent;

        public override string ToString()
        {
            return QuestionContent;
        }
    }
}
