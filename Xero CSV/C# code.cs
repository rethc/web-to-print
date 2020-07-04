//C# program code. You can run any macro from it by changing the name of the macro and file that its saved in on line 45

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
				

namespace Macros
{
    public partial class Form1 : Form
    {

        List<String> files = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object oMissing = System.Reflection.Missing.Value;

            //Create an instance of Microsoft Excel, make it visible and open invoice.xls
            Excel.Application oExcel = new Excel.Application();
            oExcel.Visible = true;
            Excel.Workbooks oBooks = oExcel.Workbooks;
            Excel._Workbook oBook = null;

            int index = comboBox1.SelectedIndex;

            oBook = oBooks.Open(files[index], oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing,
                                                                oMissing, oMissing, oMissing, oMissing, oMissing, oMissing);
                    
            //Run the macro sub CSV() in the PERSONAL.XLSB file
            oExcel.Run("'c:\\csv\\PERSONAL.XLSB'!CSV");

            //Quit Excel and clean up
            oBook.Close(false, oMissing, oMissing);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oBook);
            oBook = null;
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oBooks);
            oBooks = null;
            oExcel.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oExcel);
            oExcel = null;
    
            GC.Collect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Search for all excel files in the directory
			files.AddRange(System.IO.Directory.GetFiles("c:\\csv").Where(name => name.EndsWith(".xls")));

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

			
            foreach (string f in files)
            {
                comboBox1.Items.Add(f);
            }

            comboBox1.SelectedIndex = 0;
        }
    }
}