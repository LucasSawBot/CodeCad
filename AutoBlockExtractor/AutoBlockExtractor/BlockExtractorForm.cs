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

namespace AutoBlockExtractor
{
    public partial class BlockExtractorForm : Form
    {
        public BlockExtractorForm()
        {
            InitializeComponent();
        }

        private void BlockExtractorForm_Load(object sender, EventArgs e)
        {
            LoadDrawing(txtPath.Text);
        }

        public void LoadDrawing(string dwgPath)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = dwgPath;

                //string[] files = Directory.GetFiles(dwgPath,".dwg");
                string[] files = Directory.GetFiles(dwgPath,"*.dwg");


                if (files.Length > 0)
                {
                    //Load all the drawing files into the listbox
                    foreach (string dwg in files)
                    {
                        chkLstDwgs.Items.Add(dwg);
                    }
                    lbInfo.Text = "total number of drawings = " + chkLstDwgs.Items.Count;


                }
            }
        }

        private void btnBrowerFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = txtPath.Text;
                DialogResult resual = fbd.ShowDialog();

                if(resual == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath, "*.dwg");

                    //clear the listbox and load all the drawong
                    chkLstDwgs.Items.Clear();
                    foreach (string dwg in files)
                    {
                        chkLstDwgs.Items.Add(dwg);
                    }

                }

                lbInfo.Text = "total numbers = " + chkLstDwgs.Items.Count;
                txtPath.Text = fbd.SelectedPath;


            }
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectAll.Checked)
            {
                for (int i = 0; i < chkLstDwgs.Items.Count; i++)
                {
                    chkLstDwgs.SetItemChecked(i, true);
                }
                btnExtractBlocks.Enabled = true;
            }
            else
            {
                for (int i = 0; i < chkLstDwgs.Items.Count; i++)
                {
                    chkLstDwgs.SetItemChecked(i, false);
                }
                btnExtractBlocks.Enabled = false;
            }
            lbInfo.Text = "number if selected drawings = " + chkLstDwgs.CheckedItems.Count;
        }

        private void btnExtractBlocks_Click(object sender, EventArgs e)
        {
            if (txtBlockname.Text == "")
            {
                lbInfo.Text = "Please enter the block name to extract";
                lbInfo.ForeColor = Color.Red;
                txtBlockname.Focus();
                return;
            }

            int i = 1;
            int totalCount = chkLstDwgs.CheckedItems.Count;
            string blockName = txtBlockname.Text.Trim();

            BlockExtractorUtil beu = new BlockExtractorUtil();
            foreach (string dwgFile in chkLstDwgs.CheckedItems)
            {
                lbInfo.Text = "processing (" + i.ToString() + "of" + totalCount.ToString() + ") :" + dwgFile;
                lbInfo.ForeColor = Color.Green;
                string fileName = dwgFile + "_blocks.txt";
                beu.ProcessBlockExtraction(dwgFile, blockName, fileName);
                i += 1;
            }
            lbInfo.Text = "Extraction of blcoks completed successfully";

        }
    }
}
