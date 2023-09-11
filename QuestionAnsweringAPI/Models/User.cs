namespace QuestionAnsweringAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int FullName { get; set; }
        public List<Question> Questions { get; set; }
        public List<Answer> Answers { get; set; }

    }
}
