using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LocalDataBaseApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void individualBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.individualBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Individual' table. You can move, or remove it, as needed.
            this.individualTableAdapter.Fill(this.database1DataSet1.Individual);
            timer1.Start();
         
        }


        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count = individualBindingSource.Count;
            label_total.Text =  count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.individualBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.individualBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.individualBindingSource.RemoveCurrent();
         
            
        }

      

        

       
    }
}
