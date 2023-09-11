using System.Text.Json;

namespace QuestionAnsweringAPI.Models
{
    public static class QuestionAnsweringDbContextSeedData
    {
        static object synchlock = new object();
        static volatile bool seeded = false;        
        static string filePath = "Files/Seed_Data.json";

        public static void EnsureSeedData(this QuestionDbContext context)
        {
            if (!seeded && context.Questions.Count() == 0)
            {
                lock (synchlock)
                {
                    if (!seeded)
                    {
                        var questionAnswering = GenerateData();

                        try
                        {
                            //context.Tags.AddRange(questionAnswering.Tags);
                            context.Questions.AddRange(questionAnswering.Questions);
                            context.Answers.AddRange(questionAnswering.Answers);

                            context.SaveChanges();
                            seeded = true;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Something went wrong {ex.Message}");
                        }
                        
                    }
                }
            }
        }

        #region Data
        public static MyDataModel GenerateData()
        {
                        
            var data = new MyDataModel();

            if (File.Exists(filePath))
            {
                try
                {                    
                    string jsonContent = File.ReadAllText(filePath);
                    data = JsonSerializer.Deserialize<MyDataModel>(jsonContent);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading or deserializing the JSON file: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("The JSON file does not exist.");
            }
            return data;
        }

        #endregion
    }

    public class MyDataModel
    {
        public Question[] Questions { get; set; }
        public Answer[] Answers { get; set; }
        
    }
}
