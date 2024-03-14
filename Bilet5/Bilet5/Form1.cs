using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bilet5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cURSURIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cURSURIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bilet5_BazadateDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
              // TODO: This line of code loads data into the 'bilet5_BazadateDataSet.PROFESORI' table. You can move, or remove it, as needed.
             //this.pROFESORITableAdapter.Fill(this.bilet5_BazadateDataSet.PROFESORI);
            // TODO: This line of code loads data into the 'bilet5_BazadateDataSet.CURSURI' table. You can move, or remove it, as needed.
           //this.cURSURITableAdapter.Fill(this.bilet5_BazadateDataSet.CURSURI);
            bilet5_BazadateDataSet.EnforceConstraints = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cerinta1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void cerinta2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void cerinta3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            cURSURITableAdapter.Cerinta1(this.bilet5_BazadateDataSet.CURSURI);
            DataTable dt = this.bilet5_BazadateDataSet.CURSURI;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                richTextBox1.Text += dt.Rows[i]["Expr1"].ToString() + ' ' + dt.Rows[i]["denumire"].ToString() + '\n';
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            pROFESORITableAdapter.Cerinta2(bilet5_BazadateDataSet.PROFESORI);
            DataTable dt = this.bilet5_BazadateDataSet.PROFESORI;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                richTextBox2.Text += dt.Rows[i]["nume"].ToString().Trim() + ' ' + dt.Rows[i]["prenume"].ToString().Trim() + dt.Rows[i]["nr_cursuri"]  + '\n';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = "";
            cURSURITableAdapter.Cerinta3(this.bilet5_BazadateDataSet.CURSURI,textBox1.Text,textBox2.Text);
            DataTable dt = this.bilet5_BazadateDataSet.CURSURI;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                richTextBox3.Text += dt.Rows[i]["denumire"].ToString().Trim() + ' ' + dt.Rows[i]["nr_locuri"].ToString().Trim() +  ' ' + dt.Rows[i]["nume"].ToString().Trim() + ' ' + dt.Rows[i]["prenume"].ToString().Trim() + '\n';
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
