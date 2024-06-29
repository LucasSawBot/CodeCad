using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ControlDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string choice = "";

            //using combobox
            //choice = cboOptions.SelectedItem.ToString();

            //using Textbox
            //choice = txtItem.Text.Trim();

            //using radio button


            //if (rdLayer.Checked)
            //{
            //    choice = rdLayer.Text;
            //}
            //if (rdLineType.Checked)
            //{
            //    choice = rdLineType.Text;
            //}
            //if (rdTextStyle.Checked)
            //{
            //    choice = rdTextStyle.Text;
            //}

            //using checkbox
            if (chbLayer.Checked)
            {
                choice = chbLayer.Text + ",";
            }
            if (chbLineType.Checked)
            {
                choice += chbLineType.Text + ",";
            }
            if (chbTextstyle.Checked)
            {
                choice += chbTextstyle.Text;
            }

            if(chbLayer.Checked && chbLineType.Checked && chbTextstyle.Checked)
            {
                choice = "All";
            }

            string[] choices = choice.Split(',');
            for (int i = 0; i < choices.Length; i++)
            {
                choice = choices[i];
                DisplayItem(choice);
            }
           
        }


        private void DisplayItem(string choice)
        {
            ControlsDemoUtils cutil = new ControlsDemoUtils();
            if (choice == "Layer")
            {
                ArrayList layers = cutil.GetLayer();
                lstLayer.DataSource = layers;
                lstLineType.DataSource = null;
                lstTextStyle.DataSource = null;
                lbLayerCount.Text = layers.Count.ToString() + "Layers";
            }
            else if (choice == "Linetype")
            {
                ArrayList linetypes = cutil.GetLineType();
                lstLayer.DataSource = null;
                lstLineType.DataSource = linetypes;
                lstTextStyle.DataSource = null;
                lbLineTypeCount.Text = linetypes.Count.ToString() + "LineType";
            }
            else if (choice == "Textstyle")
            {
                ArrayList textstyle = cutil.GetTextstyle();
                lstLayer.DataSource = null;
                lstLineType.DataSource = null;
                lstTextStyle.DataSource = textstyle;
                lbTextStyleCount.Text = textstyle.Count.ToString() + "TextStyle";
            }
            else if (choice == "All")
            {
                ArrayList textstyle = cutil.GetTextstyle();
                ArrayList layers = cutil.GetLayer();
                ArrayList linetypes = cutil.GetLineType();
                lstLayer.DataSource = layers;
                lstLineType.DataSource = linetypes;
                lstTextStyle.DataSource = textstyle;
                lbLineTypeCount.Text = linetypes.Count.ToString() + "LineType";
                lbLayerCount.Text = layers.Count.ToString() + "Layers";
                lbTextStyleCount.Text = textstyle.Count.ToString() + "TextStyle";
            }
            else
            {
                MessageBox.Show("Please enter a valid value", "Invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstLayer.DataSource = null;
            lstTextStyle.DataSource = null;
            lstLineType.DataSource = null;
        }
    }
}
