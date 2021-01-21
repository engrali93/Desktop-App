using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace DailyTool
{
    class formula
    {
        public string convert_formula(string loc, IProgress<int> progress)
        {
            // Create a new Microsoft Word application object
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            
            // C# doesn't have optional arguments so we'll need a dummy value
            object oMissing = System.Reflection.Missing.Value;

            // Get list of Word files in specified directory
           
            object filename = loc;

            word.Visible = false;
            word.ScreenUpdating = false;
            word.DisplayAlerts = WdAlertLevel.wdAlertsNone;

            ////////////////////
            progress.Report(35);
            ///////////////////


            // Use the dummy value as a placeholder for optional arguments
            Document doc = word.Documents.Open(ref filename, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing);
                doc.Activate();

                object outputFileName = filename.ToString().Replace(".docx", ".pdf");
                object fileFormat = WdSaveFormat.wdFormatPDF;
            ////////////////////
            progress.Report(75);
            ///////////////////
            // Save document into PDF Format
            doc.SaveAs(ref outputFileName,
                    ref fileFormat, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing);

                // Close the Word document, but leave the Word application open.
                // doc has to be cast to type _Document so that it will find the
                // correct Close method.                
                object saveChanges = WdSaveOptions.wdDoNotSaveChanges;
                ((_Document)doc).Close(ref saveChanges, ref oMissing, ref oMissing);
                doc = null;

                // word has to be cast to type _Application so that it will find
                // the correct Quit method.
                ((_Application)word).Quit(ref oMissing, ref oMissing, ref oMissing);
                word = null;
           // var pos = outputFileName.ToString();
           // pos = pos.Replace("\\", "-");

            int num = (outputFileName.ToString()).LastIndexOf("\\");
            // var new_loc = (outputFileName.ToString()).Substring((num+1),(outputFileName.ToString().Length)-(num+1));
            var new_loc = (outputFileName.ToString()).Substring(0,(num));

            //   Process.Start("explorer.exe", outputFileName.ToString() ); 
            progress.Report(100);
            return outputFileName.ToString();
        }
        
    }
}
