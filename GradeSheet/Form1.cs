using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Management.Instrumentation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeSheet
{
    public partial class GradeSheetForm : Form
    {
        int index;
        int intValue = -2;
        float floatValue = 0;
        bool found = false; //check if the course exist in the table
        //Hashtable table = new Hashtable();
        //Hashtable CreditsTable = new Hashtable();
     
        public GradeSheetForm()
        {
            InitializeComponent();

        }

     

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void NameCourse_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
                if (!IsCorrectType(GradeTB.Text, CreditsTB.Text))
                {
                    MessageBox.Show("Invalide input, please try again");
                }
                else 
                {
                    foreach (DataGridViewRow item in this.dataGridView1.Rows)
                    {
                    
                        if(((String)item.Cells[0].Value).Equals((String)this.NameTB.Text.Trim()))
                        {
                            MessageBox.Show("This course has already been added to the list, try different course name");
                            found = true;
                            return;
                        }
                    }
                    if (found == false)
                    { 
                            dataGridView1.Rows.Add(NameTB.Text, GradeTB.Text, CreditsTB.Text);
                            
                            

                    }

                    findMinMax(GradeTB.Text);
                    findAverage(GradeTB.Text, CreditsTB.Text);
                    clear();

            }
           
        }
        private void findAverage(String GradeTB,String CreditsTB)
        {
            float counter = 0;
            float denominator = 0;
            float answer = 0;

            foreach (DataGridViewRow item in this.dataGridView1.Rows)
            {
                float a = float.Parse(item.Cells[1].Value.ToString());
                float b = float.Parse(item.Cells[2].Value.ToString());
                counter = counter + a * b;
                denominator = denominator + b;

            }
            answer = (counter / denominator);
            ave.Text = answer.ToString();
        }
        private void findMinMax( String GradeTB)
        {
            float min = 101;
            float max = -1;

            if (float.Parse(GradeTB) > max)
            {
                max = float.Parse(GradeTB);
                highest.Text = max.ToString();
            }
            if (float.Parse(GradeTB) < min)
            {
                min = float.Parse(GradeTB);
                lowest.Text = min.ToString();
            }
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow newData = dataGridView1.Rows[index];
                if (!IsCorrectType(GradeTB.Text, CreditsTB.Text))
                {
                    MessageBox.Show("Invalide input, please try again");
                }
                else
                {
                    newData.Cells[0].Value = NameTB.Text;
                    newData.Cells[1].Value = GradeTB.Text;
                    newData.Cells[2].Value = CreditsTB.Text;
                    findMinMax(GradeTB.Text);
                    findAverage(GradeTB.Text, CreditsTB.Text);

                }
            } 
            catch (Exception ex)
            { 
                MessageBox.Show("Exception occured while trying to update, please try again");
            }
        }

        public bool IsCorrectType(string GradeTB,string CreditsTB)
        {
            if (float.TryParse(GradeTB, out floatValue) && Int32.TryParse(CreditsTB, out intValue) == true)
                if (float.Parse(GradeTB) >= 0 && float.Parse(GradeTB)<=100 && (int.Parse(CreditsTB) > 0))
                    return true;
            return false;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
               
            }
            lowest.Text = " ";
            highest.Text = " ";
            ave.Text = " ";
            
            findMinMax(GradeTB.Text);
            findAverage(GradeTB.Text, CreditsTB.Text);
            clear();

        }


        void clear()
        {
            NameTB.Text = " ";
            GradeTB.Text = " ";
            CreditsTB.Text = " ";
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            NameTB.Text = row.Cells[0].Value.ToString();
            GradeTB.Text = row.Cells[1].Value.ToString();
            CreditsTB.Text = row.Cells[2].Value.ToString();
        }
    }
}
