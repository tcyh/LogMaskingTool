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
using System.Configuration;

namespace LogMaskingTool
{
    public partial class Form1 : Form
    {
        private List<Term> termsList = new List<Term> ();

        public Form1()
        {
            LoadTerms();
            InitializeComponent();
            
        }

        private void LoadTerms()
        {
            DataTable datatable = new DataTable();
            StreamReader streamreader = new StreamReader(ConfigurationManager.AppSettings["DefaultTermsFileDir"].ToString());
            char[] delimiter = new char[] { '\t' };
            //string[] columnheaders = streamreader.ReadLine().Split(delimiter);

            while (streamreader.Peek() >= 0)
            {
                //datatable.NewRow();
                String[] termpair = streamreader.ReadLine().Split(delimiter);
                //datatable.Rows.Add(termpair);
                Console.WriteLine(termpair[0] + ":" + termpair[1] + ":" + termpair[2]);

                //DataRow datarow = datatable.NewRow();
                //datatable.Rows.Add(streamreader.ReadLine());
            }
           


        }




        private void btnBrowseLogDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                //textBox1.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }


    }
}
