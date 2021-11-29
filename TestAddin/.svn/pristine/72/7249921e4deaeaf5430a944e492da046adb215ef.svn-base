using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.Office.Tools.Word;
using Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace TestAddin
{

    public partial class contetnCon : Form
    {
        private Microsoft.Office.Tools.Word.RichTextContentControl RichTextContentControl;
        private Microsoft.Office.Tools.Word.PlainTextContentControl PlainTextContentControl;
        private Microsoft.Office.Tools.Word.PictureContentControl PictureContentControl;
        private Microsoft.Office.Tools.Word.DatePickerContentControl DatePickerContentControl;
        
        public contetnCon()
        {
            InitializeComponent();
        }

        private void contetnCon_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Content Control Added");
            Document currentDocument = Globals.ThisAddIn.Application.ActiveDocument;
            Selection currentSelection = Globals.ThisAddIn.Application.Selection;
            //MessageBox.Show(currentSelection.ToString());
           // currentDocument.Paragraphs[1].Range.InsertParagraphBefore();
           // currentDocument.Paragraphs[1].Range.Select();

            string text = comboBox1.GetItemText(comboBox1.SelectedItem);
            //MessageBox.Show(text);

            switch (text)
            {
                case "RichTextContentControl":
                    WdContentControlType rich = WdContentControlType.wdContentControlRichText;
                    RichTextContentControl = (Microsoft.Office.Tools.Word.RichTextContentControl)currentSelection.Range.ContentControls.Add(rich);
                    //MessageBox.Show("Rich Text CC Added");
                    break;
                case "PlainTextContentControl":
                    WdContentControlType plain = WdContentControlType.wdContentControlText;
                    PlainTextContentControl = (Microsoft.Office.Tools.Word.PlainTextContentControl)currentSelection.Range.ContentControls.Add(plain);
                    break;
                case "Picture Content Control":
                    WdContentControlType picture = WdContentControlType.wdContentControlPicture;
                    PictureContentControl = (Microsoft.Office.Tools.Word.PictureContentControl)currentSelection.Range.ContentControls.Add(picture);
                    break;
                case "Date Picker":
                    WdContentControlType date = WdContentControlType.wdContentControlDate;
                    DatePickerContentControl = (Microsoft.Office.Tools.Word.DatePickerContentControl)currentSelection.Range.ContentControls.Add(date);
                    break;
                default:
                    break;
            }
        }
    }
}