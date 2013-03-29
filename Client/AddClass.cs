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
    public partial class AddClass : Form
    {
        private readonly Class cls;
        public AddClass(Class cls)
        {
            InitializeComponent();

            this.cls = cls;
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            cls.Name = txtClassName.Text ;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
