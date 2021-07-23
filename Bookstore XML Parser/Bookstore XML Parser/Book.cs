using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Bookstore_XML_Parser
{
    public class Book
    {
        public Book(XmlNode node)
        {
            id = node.Attributes.GetNamedItem("id").Value;

            if (!node.HasChildNodes) { return; }

            for (int i = 0; i < node.ChildNodes.Count; i++)
            {
                if (node.ChildNodes.Item(i).Name == "author" && string.IsNullOrWhiteSpace(author))
                { author = node.ChildNodes.Item(i).InnerText; }

                if (node.ChildNodes.Item(i).Name == "description" && string.IsNullOrWhiteSpace(description))
                { description = node.ChildNodes.Item(i).InnerText; }

                if (node.ChildNodes.Item(i).Name == "genre" && string.IsNullOrWhiteSpace(genre))
                { genre = node.ChildNodes.Item(i).InnerText; }

                if (node.ChildNodes.Item(i).Name == "price" && string.IsNullOrWhiteSpace(price))
                { price = node.ChildNodes.Item(i).InnerText; }

                if (node.ChildNodes.Item(i).Name == "publish_date" && string.IsNullOrWhiteSpace(publish_date))
                { publish_date = node.ChildNodes.Item(i).InnerText; }

                if (node.ChildNodes.Item(i).Name == "title" && string.IsNullOrWhiteSpace(title))
                { title = node.ChildNodes.Item(i).InnerText; }
            }
        }

        #region Properties

        private const string csvTemplate = "\"{0}\",\"{1}\",\"{2}\",\"{3}\",{4},{5},\"{6}\"\r\n";

        public const string CSVHeader = "id,author,title,genre,price,publish_date,description\r\n";

        private string author { get; set; }
        private string description { get; set; }
        private string genre { get; set; }
        private string id { get; set; }
        private string price { get; set; }
        private string publish_date { get; set; }
        private string title { get; set; }

        public string Author { get { return author; } }
        public string Description { get { return description; } }
        public string Genre { get { return genre; } }
        public string ID { get { return id; } }
        public decimal? Price
        {
            get
            {
                Decimal d = -1;
                Decimal.TryParse(price, out d);

                if (d < 0) { return null; }
                return d;
            }
        }
        public int? PriceRoundedUp
        {
            get
            {
                if (Price == null) { return null; }

                return (int)Math.Ceiling((decimal)Price);
            }
        }
        public DateTime? PublishDate
        {
            get
            {
                DateTime dt = DateTime.MinValue;
                DateTime.TryParse(publish_date, out dt);

                if (dt == DateTime.MinValue) { return null; }
                return dt;
            }
        }
        public string Title { get { return title; } }
        public bool WasPublishedOnSunday
        {
            get
            {
                if (PublishDate == null) { return false; }

                return (PublishDate.Value.DayOfWeek == DayOfWeek.Sunday);
            }
        }

        #endregion

        public string ToCSVLineWithPriceRoundedup()
        {
            return string.Format(csvTemplate, ID, Author, Title, Genre, PriceRoundedUp, PublishDate, Description);
        }
    }
}
