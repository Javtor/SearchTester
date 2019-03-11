using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistMeProject.Models
{
    public class BaseClass
    {

        public List<Document> Docs;
        private BM25Searcher _searcher;

        public BaseClass()
        {
            Docs = new List<Document>();
            _searcher = new BM25Searcher();
        }

        public void AddDocument(string text)
        {
            Document doc = new Document(text);
            Docs.Add(doc);
            _searcher.AddDocument(doc);
        }

    }
}
