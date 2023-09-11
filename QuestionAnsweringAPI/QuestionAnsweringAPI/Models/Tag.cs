namespace QuestionAnsweringAPI.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Question> Questions { get; set; } = new List<Question>();
    }
}
