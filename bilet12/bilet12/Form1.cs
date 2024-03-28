using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bilet12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cARTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cARTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza_bilet12DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza_bilet12DataSet.EDITURA' table. You can move, or remove it, as needed.
            this.eDITURATableAdapter.Fill(this.baza_bilet12DataSet.EDITURA);
            // TODO: This line of code loads data into the 'baza_bilet12DataSet.CARTE' table. You can move, or remove it, as needed.
            this.cARTETableAdapter.Fill(this.baza_bilet12DataSet.CARTE);
            baza_bilet12DataSet.EnforceConstraints = false;

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
            eDITURATableAdapter.Cerinta2(baza_bilet12DataSet.EDITURA);
            DataTable dt = baza_bilet12DataSet.EDITURA;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                richTextBox2.Text += dt.Rows[i]["Denumire"].ToString().Trim() + " " + dt.Rows[i]["Titlu"].ToString().Trim() + " " + dt.Rows[i]["Autor"].ToString().Trim() + "\n";
            }
        }

        private void cerinta3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            richTextBox3.Clear();
            cARTETableAdapter.Cerinta3(baza_bilet12DataSet.CARTE);
            DataTable dt = baza_bilet12DataSet.CARTE;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                richTextBox3.Text += dt.Rows[i]["Domeniu"].ToString().Trim() + " " + dt.Rows[i]["Titlu"].ToString().Trim() + " " + dt.Rows[i]["Autor"].ToString().Trim() + " " + dt.Rows[i]["Denumire"].ToString().Trim() + "\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cARTETableAdapter.Cerinta1(baza_bilet12DataSet.CARTE,textBox1.Text);
            DataTable dt = baza_bilet12DataSet.CARTE;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                richTextBox1.Text += dt.Rows[i]["Titlu"].ToString().Trim() + " " + dt.Rows[i]["Autor"].ToString().Trim() + "\n";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
