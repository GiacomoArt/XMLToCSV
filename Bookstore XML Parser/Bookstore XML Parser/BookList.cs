using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Bookstore_XML_Parser
{
    public static class BookList
    {
        public static void Load(this List<Book> t, XmlDocument xmlDocument)
        {
            t.Clear();

            if (xmlDocument == null) { return; }

            XmlNodeList bookNodes = xmlDocument.GetElementsByTagName("book");
            for (int i = 0; i < bookNodes.Count; i++)
            { t.Add(new Book(bookNodes.Item(i))); }
        }

        public static void ApplyCSVFilters(this List<Book> t)
        {
            List<Book> books = t.Where(b => 
                !b.Author.ToLower().Contains("shrub")
                && !b.WasPublishedOnSunday
            ).ToList();

            t.Clear();
            t.AddRange(books);
        }
    }
}
