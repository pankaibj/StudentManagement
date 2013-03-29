namespace Client
{
    partial class FormContainer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.tpClasses = new System.Windows.Forms.TabPage();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.cmsDeleteClasses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteItToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpStudents = new System.Windows.Forms.TabPage();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.cmsDeleteStudent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteItToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabContainer.SuspendLayout();
            this.tpClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.cmsDeleteClasses.SuspendLayout();
            this.tpStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.cmsDeleteStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabContainer
            // 
            this.tabContainer.Controls.Add(this.tpClasses);
            this.tabContainer.Controls.Add(this.tpStudents);
            this.tabContainer.Location = new System.Drawing.Point(12, 12);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(528, 317);
            this.tabContainer.TabIndex = 0;
            // 
            // tpClasses
            // 
            this.tpClasses.Controls.Add(this.btnAddClass);
            this.tpClasses.Controls.Add(this.dgvClasses);
            this.tpClasses.Location = new System.Drawing.Point(4, 22);
            this.tpClasses.Name = "tpClasses";
            this.tpClasses.Padding = new System.Windows.Forms.Padding(3);
            this.tpClasses.Size = new System.Drawing.Size(520, 291);
            this.tpClasses.TabIndex = 0;
            this.tpClasses.Text = "Classes";
            this.tpClasses.UseVisualStyleBackColor = true;
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(192, 237);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(125, 30);
            this.btnAddClass.TabIndex = 1;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClasses_Click);
            // 
            // dgvClasses
            // 
            this.dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasses.BackgroundColor = System.Drawing.Color.White;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.ContextMenuStrip = this.cmsDeleteClasses;
            this.dgvClasses.Location = new System.Drawing.Point(19, 20);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RowHeadersVisible = false;
            this.dgvClasses.RowTemplate.Height = 23;
            this.dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasses.Size = new System.Drawing.Size(466, 187);
            this.dgvClasses.TabIndex = 0;
            this.dgvClasses.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasses_CellValueChanged);
            // 
            // cmsDeleteClasses
            // 
            this.cmsDeleteClasses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteItToolStripMenuItem});
            this.cmsDeleteClasses.Name = "cmsDeleteClasses";
            this.cmsDeleteClasses.Size = new System.Drawing.Size(128, 26);
            // 
            // deleteItToolStripMenuItem
            // 
            this.deleteItToolStripMenuItem.Name = "deleteItToolStripMenuItem";
            this.deleteItToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.deleteItToolStripMenuItem.Text = "Delete it.";
            this.deleteItToolStripMenuItem.Click += new System.EventHandler(this.deleteItToolStripMenuItem_Click);
            // 
            // tpStudents
            // 
            this.tpStudents.Controls.Add(this.btnAddStudent);
            this.tpStudents.Controls.Add(this.dgvStudents);
            this.tpStudents.Location = new System.Drawing.Point(4, 22);
            this.tpStudents.Name = "tpStudents";
            this.tpStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tpStudents.Size = new System.Drawing.Size(520, 291);
            this.tpStudents.TabIndex = 1;
            this.tpStudents.Text = "Students";
            this.tpStudents.UseVisualStyleBackColor = true;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(188, 236);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(103, 30);
            this.btnAddStudent.TabIndex = 6;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.StudentName,
            this.ClassName});
            this.dgvStudents.ContextMenuStrip = this.cmsDeleteStudent;
            this.dgvStudents.Location = new System.Drawing.Point(6, 6);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.RowTemplate.Height = 23;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(505, 195);
            this.dgvStudents.TabIndex = 0;
            this.dgvStudents.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellValueChanged);
            // 
            // cmsDeleteStudent
            // 
            this.cmsDeleteStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteItToolStripMenuItem1});
            this.cmsDeleteStudent.Name = "contextMenuStrip1";
            this.cmsDeleteStudent.Size = new System.Drawing.Size(128, 26);
            // 
            // deleteItToolStripMenuItem1
            // 
            this.deleteItToolStripMenuItem1.Name = "deleteItToolStripMenuItem1";
            this.deleteItToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.deleteItToolStripMenuItem1.Text = "Delete it.";
            this.deleteItToolStripMenuItem1.Click += new System.EventHandler(this.deleteItToolStripMenuItem1_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "Name";
            this.StudentName.HeaderText = "StudentName";
            this.StudentName.Name = "StudentName";
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "Class";
            this.ClassName.HeaderText = "ClassName";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // FormContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 341);
            this.Controls.Add(this.tabContainer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentManagement";
            this.Load += new System.EventHandler(this.FormContainer_Load);
            this.tabContainer.ResumeLayout(false);
            this.tpClasses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.cmsDeleteClasses.ResumeLayout(false);
            this.tpStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.cmsDeleteStudent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage tpClasses;
        private System.Windows.Forms.TabPage tpStudents;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.ContextMenuStrip cmsDeleteClasses;
        private System.Windows.Forms.ToolStripMenuItem deleteItToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsDeleteStudent;
        private System.Windows.Forms.ToolStripMenuItem deleteItToolStripMenuItem1;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;

    }
}

