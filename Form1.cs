using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student.s
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbStudentsDataSet1.tbStudents' table. You can move, or remove it, as needed.
            this.tbStudentsTableAdapter1.Fill(this.dbStudentsDataSet1.tbStudents);
            // TODO: This line of code loads data into the 'dbStudentsDataSet.tbStudents' table. You can move, or remove it, as needed.
            this.tbStudentsTableAdapter.Fill(this.dbStudentsDataSet.tbStudents);

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tbStudentsBindingSource1.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tbStudentsBindingSource1.EndEdit();
            tbStudentsTableAdapter1.Update(dbStudentsDataSet1.tbStudents);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbStudentsBindingSource1.RemoveCurrent();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            tbStudentsBindingSource1.MoveFirst();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbStudentsBindingSource1.MoveLast();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tbStudentsBindingSource1.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbStudentsBindingSource1.MoveNext();    
        }
    }
}
