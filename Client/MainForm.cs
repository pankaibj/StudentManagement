using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Data.Entity;

namespace Client
{
    public partial class FormContainer : Form
    {
       // private List<Class> list;

        public FormContainer()
        {
            InitializeComponent();
           
            LoadStudentToDataGridView(context.Students.ToList());
        }

        private void CreateColumnToDataGridView()
        {

            var column = new DataGridViewTextBoxColumn();
            column.ReadOnly = true;
            column.HeaderText = "ID";
            column.DisplayIndex = 0;
            column.Name ="ID";
            dgvClasses.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Class Name";
            column.DisplayIndex = 1;
            column.Name = "Class Name";
            dgvClasses.Columns.Add(column);
        }

        private void CreateColumnToStudent()
        {

            var column = new DataGridViewTextBoxColumn();
            column.ReadOnly = true;
            column.HeaderText = "ID";
            column.DisplayIndex = 0;
            column.Name = "ID";
            dgvStudents.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Name";
            column.DisplayIndex = 1;
            column.Name = "Student Name";
            dgvStudents.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Class Name";
            column.DisplayIndex = 1;
            column.Name = "Class Name";
            dgvStudents.Columns.Add(column);
        }

        private void LoadDataToDataGridView(List<Class> cls)
        {
            foreach (Class t in cls)
            {
                dgvClasses.Rows.Add(t.Id, t.Name);
            }
        }

        private void LoadStudentToDataGridView(List<Student> cls)
        {
            foreach (Student s in cls)
            {
                dgvStudents.Rows.Add(s.Id, s.Name,s.Class.Name);
            }
        }

        private readonly StudentContext context = new StudentContext();

        private void FormContainer_Load(object sender, EventArgs e)
        {
            dgvClasses.AutoGenerateColumns = false;
            dgvStudents.AutoGenerateColumns = false;

            CreateColumnToDataGridView();
            LoadDataToDataGridView(new StudentContext().Classes.ToList());
            
            
           
        }


        private void btnAddClasses_Click(object sender, EventArgs e)
        {
            var cls = new Class();
            var add = new AddClass(cls);
            if (add.ShowDialog() == DialogResult.OK)
            {
                context.Classes.Add(cls);
                context.SaveChanges();
                ClearClassData();

            }
        }

        public void ClearClassData()
        {
            if (dgvClasses.Rows.Count > 0)
                {
                    dgvClasses.Rows.Clear();
                    LoadDataToDataGridView(new StudentContext().Classes.ToList());
                }
        }

        public void ClearStudentsData()
        {
            if (dgvStudents.Rows.Count > 0)
            {
                dgvStudents.Rows.Clear();
                LoadStudentToDataGridView(new StudentContext().Students.ToList());
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var stu = new Student();
            var student = new AddStudent(stu,context);
            if (student.ShowDialog() == DialogResult.OK)
            {
              
                context.Students.Add(stu);
                context.SaveChanges();

                ClearStudentsData();

            }

        }

        private void deleteItToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvClasses.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvClasses.CurrentRow.Cells[0].Value);

                var classes = context.Classes.FirstOrDefault(p => p.Id == id);

                DialogResult flag = MessageBox.Show("Do you wanna delete this row's data ?", "Caution!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (flag == DialogResult.Yes)
                {
                    context.Classes.Remove(classes);
                    context.SaveChanges();

                    ClearClassData();
                }
            }
        }

        private void deleteItToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvStudents.CurrentRow.Cells[0].Value);

                var students = context.Students.FirstOrDefault(p => p.Id == id);

                DialogResult flag = MessageBox.Show("Do you wanna delete this row's data ?", "Caution!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                if (flag == DialogResult.Yes)
                {
                    context.Students.Remove(students);
                    context.SaveChanges();

                    ClearStudentsData();
                }
            }
        }

        private void dgvStudents_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStudents.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvStudents.CurrentRow.Cells[0].Value);

                var students = context.Students.FirstOrDefault(p => p.Id == id);

                if (students != null)
                {
                    students.Name = dgvStudents.CurrentRow.Cells[1].Value.ToString();
                }
                context.SaveChanges();
            }
        }

        private void dgvClasses_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClasses.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvClasses.CurrentRow.Cells[0].Value);

                var classes = context.Classes.FirstOrDefault(p => p.Id == id);

                if (classes != null)

                    classes.Name = dgvClasses.CurrentRow.Cells[1].Value.ToString();

                context.SaveChanges();
            }
        }
    }
}
