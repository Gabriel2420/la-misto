using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bilet13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void jUDETBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jUDETBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza_bilet13DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza_bilet13DataSet.LOCALITATE' table. You can move, or remove it, as needed.
            this.lOCALITATETableAdapter.Fill(this.baza_bilet13DataSet.LOCALITATE);
            // TODO: This line of code loads data into the 'baza_bilet13DataSet.JUDET' table. You can move, or remove it, as needed.
            this.jUDETTableAdapter.Fill(this.baza_bilet13DataSet.JUDET);
            baza_bilet13DataSet.EnforceConstraints = false;

        }

        private void cerinta1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            textBox1.Clear();
            richTextBox1.Clear();
        }

        private void cerinta2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            richTextBox2.Clear();
            jUDETTableAdapter.Cerinta2(baza_bilet13DataSet.JUDET);
            DataTable dt = baza_bilet13DataSet.JUDET;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                richTextBox2.Text += dt.Rows[i]["Denumire"].ToString().Trim() + " " + dt.Rows[i]["Nrloc"].ToString().Trim() + " " + dt.Rows[i]["SuprafataTotala"].ToString().Trim() + " " + dt.Rows[i]["PopulatiaTotala"].ToString().Trim() + "\n";  
            }
        }

        private void cerinta3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            richTextBox3.Clear();
            lOCALITATETableAdapter.Cerinta3(baza_bilet13DataSet.LOCALITATE);
            DataTable dt = baza_bilet13DataSet.LOCALITATE;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                richTextBox3.Text += dt.Rows[i]["Denumire"].ToString().Trim() + "    " +  dt.Rows[i]["Judet"].ToString().Trim() + "\n";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            lOCALITATETableAdapter.Cerinta1(baza_bilet13DataSet.LOCALITATE, textBox1.Text);
            DataTable dt = baza_bilet13DataSet.LOCALITATE;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                richTextBox1.Text += dt.Rows[i]["Denumire"].ToString().Trim() + "\n";
            }
        }
    }
}
