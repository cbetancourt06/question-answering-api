namespace QuestionAnsweringAPI.Models
{
    public class Answer
    {

        public int Id { get; set; }
        public string Body { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public ICollection<Vote> Votes { get; set; } = new List<Vote>();

    }
}
