namespace Domain.Models
{
    public class KnowledgeBaseArticle
    {
        public KnowledgeBaseArticle(int kbNumber, string kbLink)
        {
            KbNumber = kbNumber;
            KbLink = kbLink;
        }

        public int KbNumber { get; set; }
        public string KbLink { get; set; }
    }
}