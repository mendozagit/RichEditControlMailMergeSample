using DevExpress.XtraRichEdit.API.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichEditControlMailMergeSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void LoadDocumentButton_Click(object sender, EventArgs e)
        {
            richEditControl1.LoadDocumentTemplate("Demo.docx");
            richEditControl1.Options.MailMerge.DataSource = DataHelper.DummyRecords();
            AddMailMergeFields(richEditControl1.Document);
        }

        private void ShowAllFieldCodesButton_Click(object sender, EventArgs e)
        {

        }

        private void ShowMergeResultDocumentButton_Click(object sender, EventArgs e)
        {
            richEditControl1.MailMerge(richEditControl1.Document);
        }

        private static void AddMailMergeFields(Document document)
        {
            
            // Find a placeholder for the FirstName field:
            DocumentRange[] nameRanges =
                document.FindAll("FirstName", SearchOptions.WholeWord);
            foreach (var nameRange in nameRanges)
            {
                DocumentPosition namePosition = nameRange.End;

                // Delete the phrase
                document.Delete(nameRange);

                // Create a field at the placeholder position
                document.Fields.Create(namePosition, @"MERGEFIELD ""FirstName""");
            }



            // Find a placeholder for the FirstName field:
            DocumentRange[] lastNameRanges =
                document.FindAll("LastName", SearchOptions.WholeWord);
            foreach (var nameRange in lastNameRanges)
            {
                DocumentPosition namePosition = nameRange.End;

                // Delete the phrase
                document.Delete(nameRange);

                // Create a field at the placeholder position
                document.Fields.Create(namePosition, @"MERGEFIELD ""LastName""");
            }
        }
    }
}
