using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMappingSystem.Presentation.Models
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