namespace QuestionAnsweringAPI.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public int? QuestionId { get; set; }
        public Question Question { get; set; }
        public int? AnswerId { get; set; }
        public Answer Answer { get; set; }
        public bool IsVoted { get; set; }
    }
}
