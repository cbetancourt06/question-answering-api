namespace QuestionAnsweringAPI.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        //public List<Answer> Answers { get; set; }
        //public List<Vote> Votes { get; set; }
        //public List<Tag> Tags { get; set; }
        public ICollection<Answer> Answers { get; set; } = new List<Answer>();
        public ICollection<Tag> QuestionTags { get; set; } = new List<Tag>();
        public ICollection<Vote> Votes { get; set; } = new List<Vote>();

    }
}
