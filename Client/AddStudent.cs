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

namespace Client
{
    public partial class AddStudent : Form
    {
        private readonly Student stu;

        private readonly StudentContext context;

        public AddStudent(Student stu,StudentContext context)
        {
            InitializeComponent();
            BindClassesComboxData();
            this.stu = stu;
            this.context = context;
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(cbbClass.SelectedValue);

            var cls=context.Classes.FirstOrDefault(p => p.Id == id);
            stu.Name = txtStudent.Text;
            stu.Class = cls;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void BindClassesComboxData()
        {
            var list = new StudentContext().Classes.ToList();
            cbbClass.DataSource = list;
            cbbClass.DisplayMember = "Name";
            cbbClass.ValueMember = "Id";
        }
    }
}
