using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace TestAddin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("title", typeof(string));
            dt.Columns.Add("tag", typeof(string));
            dt.Columns.Add("allow_deletion", typeof(string));
            dt.Columns.Add("allow_editing", typeof(string));
            dt.Columns.Add("count_CC", typeof(string));
            dt.Columns.Add("type_CC", typeof(string));

            Document LobjActiveDocument = Globals.ThisAddIn.Application.ActiveDocument;
            List<ContentControl> contentControlList = LobjActiveDocument.ContentControls.OfType<ContentControl>().ToList();

            List<Model> LobjListofModel= new List<Model>();
            //Dictionary<int, string> LobjDic = new Dictionary<int, string>();
            List<string> list_title = new List<string>();

            foreach (var contentControl in contentControlList)
            {
                Model LobjModel = new Model
                {
                    title = contentControl.Title,
                    tag = contentControl.Tag,
                    allow_deletion = "Yes",
                    allow_editing = "Yes",
                    count_CC = contentControl.Title.Count(),
                    type_CC = contentControl.Type.ToString()
                };
                //LobjDic.Add(key, LobjModel.title);
                list_title.Add(LobjModel.title);
                LobjListofModel.Add(LobjModel);
            }
            var count_obj = from x in list_title
                            group x by x into g
                            let count = g.Count()
                            select new { Value = g.Key, Count = count };


            foreach (var obj in count_obj)
            {
                foreach (var contentControl in LobjListofModel)
                {
                    //var Test = (contentControl.title == obj.Value) ? "Yes" : "No";
                    if (contentControl.title == obj.Value)
                    {
                        dt.Rows.Add(contentControl.title, contentControl.tag, contentControl.allow_deletion, contentControl.allow_editing, obj.Count, contentControl.type_CC);
                        dataGridView1.DataSource = dt;
                        break;
                    }
                }
            }
            //int count = contentControlList.ContentControls.count.ToString();
        }
    }
}