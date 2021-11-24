using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Office = Microsoft.Office.Core;
using word = Microsoft.Office.Interop.Word;

// TODO:  Follow these steps to enable the Ribbon (XML) item:

// 1: Copy the following code block into the ThisAddin, ThisWorkbook, or ThisDocument class.

//  protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
//  {
//      return new Ribbon();
//  }

// 2. Create callback methods in the "Ribbon Callbacks" region of this class to handle user
//    actions, such as clicking a button. Note: if you have exported this Ribbon from the Ribbon designer,
//    move your code from the event handlers to the callback methods and modify the code to work with the
//    Ribbon extensibility (RibbonX) programming model.

// 3. Assign attributes to the control tags in the Ribbon XML file to identify the appropriate callback methods in your code.  

// For more information, see the Ribbon XML documentation in the Visual Studio Tools for Office Help.


namespace TestAddin
{
    [ComVisible(true)]
    public class Ribbon : Office.IRibbonExtensibility
    {
        private Office.IRibbonUI ribbon;

        public Ribbon()
        {
        }

        #region IRibbonExtensibility Members

        public string GetCustomUI(string ribbonID)
        {
            return GetResourceText("TestAddin.Ribbon.xml");
        }

        #endregion

        #region Ribbon Callbacks
        //Create callback methods here. For more information about adding callback methods, visit https://go.microsoft.com/fwlink/?LinkID=271226

        public void Ribbon_Load(Office.IRibbonUI ribbonUI)
        {
            this.ribbon = ribbonUI;
        }

        public void ClickMe(Office.IRibbonControl PObjRibbonControl)
        {
            // MessageBox.Show("Say Hello");
            Form1 obj = new Form1();
            obj.ShowDialog();
            //word.Document LobjActiveDocument = Globals.ThisAddIn.Application.ActiveDocument;
           // MessageBox.Show(Path.GetFileName(LobjActiveDocument.FullName));
           // List<ContentControl> contentControlList = LobjActiveDocument.ContentControls.OfType<ContentControl>().ToList();
           // string title =  contentControlList[0].Title;
            // MessageBox.Show(LobjActiveDocument.ContentControls.Count.ToString().OfType<ContentControl>().Where(x => x.Title.Equals("RTCC")).FirstOrDefault();
            // MessageBox.Show(LobjActiveDocument.ContentControls.Count.ToString().Where(x => x.Title.Equals("testCC1")).FirstOrDefault());

           // ContentControl LobjCC = LobjActiveDocument.ContentControls.OfType<ContentControl>().Where(x => x.Title.Equals("RTCC")).FirstOrDefault();
           // ContentControl countLobjCC = LobjActiveDocument.ContentControls.OfType<ContentControl>().Where(x => x.Title.Count().Equals("RTCC")).FirstOrDefault();
            //MessageBox.Show(countLobjCC.ToString());
           // word.Range LobjRange = LobjCC.Range;
            // MessageBox.Show(LobjRange.Text);
            //MessageBox.Show(obj.ShowDialog(LobjCC));
        }
        #endregion
        #region Helpers

        private static string GetResourceText(string resourceName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string[] resourceNames = asm.GetManifestResourceNames();
            for (int i = 0; i < resourceNames.Length; ++i)
            {
                if (string.Compare(resourceName, resourceNames[i], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    using (StreamReader resourceReader = new StreamReader(asm.GetManifestResourceStream(resourceNames[i])))
                    {
                        if (resourceReader != null)
                        {
                            return resourceReader.ReadToEnd();
                        }
                    }
                }
            }
            return null;
        }

        #endregion
    }
}