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
using NLog;

namespace LogMaskingTool
{
    public partial class Form1 : Form
    {
        private List<Term> termsList = new List<Term> ();
        private Logger log = LogManager.GetCurrentClassLogger();
        private DataTable dataTable = new DataTable();
      

        public Form1()
        {
            InitializeComponent();
            try
            {
                dataTable = LoadTermsFromFile();
                if(dataTable != null && dataTable.Rows.Count > 0)
                {
                    //this.dgvterms.columns.addrange(new system.windows.forms.datagridviewcolumn[] {
                    //this.termtype,
                    //this.orignal,
                    //this.replacement});
                    this.dgvTerms.DataSource = dataTable;


                    //this.TermType.DataSource = 
                    //this.TermType.DisplayMember = "TermType";
                    //this.TermType.ValueMember = "TermType";

                    

                }
                
            }
            catch (FileNotFoundException fe)
            {
                log.Debug(fe);
                MessageBox.Show("Unable to load terms file", "FileNotFoundException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                log.Debug(ex);
                MessageBox.Show("Unknown Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                InitializeComponent();
            }



        }

        private DataTable LoadTermsFromFile()
        {
            DataTable dataTable = new DataTable();
            StreamReader streamreader = new StreamReader(ConfigurationManager.AppSettings["DefaultTermsFileDir"].ToString());
            char[] delimiter = new char[] { '\t' };
            dataTable.Columns.Add("TermType");
            dataTable.Columns.Add("Original");
            dataTable.Columns.Add("Replacement");
            while (streamreader.Peek() >= 0)
            {
                string line = streamreader.ReadLine();
                if (!String.IsNullOrWhiteSpace(line))
                {
                    string[] values = line.Split(delimiter);
                    if (values.Length >= 3)
                    {   
                        DataRow dataRow = dataTable.NewRow();
                        dataRow["TermType"] = values[0];
                        dataRow["Original"] = values[1].Trim('\"');
                        dataRow["Replacement"] = values[2].Trim('\"');
                        dataTable.Rows.Add(dataRow);
                    }
                }
            }

            return dataTable;
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

        //private void logger(string header, string body)
        //{
        //    lbLogs.Items.Add(DateTime.Now.ToString() + "___" + header + "___" + body);
        //    lbLogs.SelectedIndex = lbLogs.Items.Count - 1;
        //}

    }
}
