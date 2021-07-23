using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Bookstore_XML_Parser
{
    public partial class frmXMLParser : Form
    {
        public frmXMLParser()
        {
            InitializeComponent();
        }

        #region Properties

        private List<Book> Books
        {
            get
            {
                List<Book> books = new List<Book>();
                try
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.InnerXml = txtXML.Text;
                    books.Load(xmlDocument);
                }
                catch
                { }

                return books;
            }
        }

        private List<Book> CSVFilteredBooks
        {
            get
            {
                List<Book> books = Books;
                books.ApplyCSVFilters();
                return books;
            }
        }

        #endregion

        #region Events

        private void btnSelectXMLFromFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.DefaultExt = "xml";
                openFileDialog.Filter = "xml file (*.xml)|*.xml";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load(openFileDialog.FileName);

                    txtXML.Text = xmlDocument.InnerXml;
                    btnExportXMLToCSV.Enabled = (CSVFilteredBooks.Count() > 0);
                }
            }
        }

        private void btnExportXMLToCSV_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.InnerXml = txtXML.Text;

            List<Book> books = Books;
            books.ApplyCSVFilters();

            StringBuilder csvBuilder = new StringBuilder();
            csvBuilder.Append(Book.CSVHeader);
            foreach (Book book in books)
            { csvBuilder.Append(book.ToCSVLineWithPriceRoundedup()); }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.DefaultExt = "csv";
                saveFileDialog.Filter = "csv file (*.csv)|*.csv";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                { File.WriteAllText(saveFileDialog.FileName, csvBuilder.ToString()); }
            }
        }

        private void txtXML_Leave(object sender, EventArgs e)
        {
            btnExportXMLToCSV.Enabled = (CSVFilteredBooks.Count() > 0);
        }

        #endregion
    }
}
