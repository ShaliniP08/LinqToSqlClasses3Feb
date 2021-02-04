
namespace LinqToSqlClasses3Feb
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageInsert = new System.Windows.Forms.TabPage();
            this.textBoxInsertDept = new System.Windows.Forms.TextBox();
            this.textBoxInsertSalary = new System.Windows.Forms.TextBox();
            this.textBoxInsertName = new System.Windows.Forms.TextBox();
            this.lblInsertDept = new System.Windows.Forms.Label();
            this.lblInsertSalary = new System.Windows.Forms.Label();
            this.lblInsertName = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.btnDeleteEmp = new System.Windows.Forms.Button();
            this.textBoxDeleteEmpId = new System.Windows.Forms.TextBox();
            this.lblDeleteEmpId = new System.Windows.Forms.Label();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUpdateDept = new System.Windows.Forms.Label();
            this.lblUpdateSalary = new System.Windows.Forms.Label();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.textBoxUpdateDept = new System.Windows.Forms.TextBox();
            this.textBoxUpdateSalary = new System.Windows.Forms.TextBox();
            this.textBoxUpdateName = new System.Windows.Forms.TextBox();
            this.textBoxUpdateEmpId = new System.Windows.Forms.TextBox();
            this.lblUpdateEmpId = new System.Windows.Forms.Label();
            this.btnTotalEmp = new System.Windows.Forms.Button();
            this.lblTotalEmp = new System.Windows.Forms.Label();
            this.btnShowEmp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageInsert.SuspendLayout();
            this.tabPageDelete.SuspendLayout();
            this.tabPageUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(249, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(509, 177);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageInsert);
            this.tabControl.Controls.Add(this.tabPageDelete);
            this.tabControl.Controls.Add(this.tabPageUpdate);
            this.tabControl.Location = new System.Drawing.Point(12, 236);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(792, 217);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageInsert
            // 
            this.tabPageInsert.Controls.Add(this.textBoxInsertDept);
            this.tabPageInsert.Controls.Add(this.textBoxInsertSalary);
            this.tabPageInsert.Controls.Add(this.textBoxInsertName);
            this.tabPageInsert.Controls.Add(this.lblInsertDept);
            this.tabPageInsert.Controls.Add(this.lblInsertSalary);
            this.tabPageInsert.Controls.Add(this.lblInsertName);
            this.tabPageInsert.Controls.Add(this.btnInsert);
            this.tabPageInsert.Location = new System.Drawing.Point(4, 25);
            this.tabPageInsert.Name = "tabPageInsert";
            this.tabPageInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInsert.Size = new System.Drawing.Size(784, 188);
            this.tabPageInsert.TabIndex = 0;
            this.tabPageInsert.Text = "Insert";
            this.tabPageInsert.UseVisualStyleBackColor = true;
            // 
            // textBoxInsertDept
            // 
            this.textBoxInsertDept.Location = new System.Drawing.Point(233, 119);
            this.textBoxInsertDept.Name = "textBoxInsertDept";
            this.textBoxInsertDept.Size = new System.Drawing.Size(100, 22);
            this.textBoxInsertDept.TabIndex = 6;
            // 
            // textBoxInsertSalary
            // 
            this.textBoxInsertSalary.Location = new System.Drawing.Point(233, 72);
            this.textBoxInsertSalary.Name = "textBoxInsertSalary";
            this.textBoxInsertSalary.Size = new System.Drawing.Size(100, 22);
            this.textBoxInsertSalary.TabIndex = 5;
            // 
            // textBoxInsertName
            // 
            this.textBoxInsertName.Location = new System.Drawing.Point(233, 33);
            this.textBoxInsertName.Name = "textBoxInsertName";
            this.textBoxInsertName.Size = new System.Drawing.Size(100, 22);
            this.textBoxInsertName.TabIndex = 4;
            // 
            // lblInsertDept
            // 
            this.lblInsertDept.AutoSize = true;
            this.lblInsertDept.Location = new System.Drawing.Point(97, 119);
            this.lblInsertDept.Name = "lblInsertDept";
            this.lblInsertDept.Size = new System.Drawing.Size(64, 17);
            this.lblInsertDept.TabIndex = 3;
            this.lblInsertDept.Text = "Dept No.";
            // 
            // lblInsertSalary
            // 
            this.lblInsertSalary.AutoSize = true;
            this.lblInsertSalary.Location = new System.Drawing.Point(97, 77);
            this.lblInsertSalary.Name = "lblInsertSalary";
            this.lblInsertSalary.Size = new System.Drawing.Size(48, 17);
            this.lblInsertSalary.TabIndex = 2;
            this.lblInsertSalary.Text = "Salary";
            // 
            // lblInsertName
            // 
            this.lblInsertName.AutoSize = true;
            this.lblInsertName.Location = new System.Drawing.Point(97, 36);
            this.lblInsertName.Name = "lblInsertName";
            this.lblInsertName.Size = new System.Drawing.Size(45, 17);
            this.lblInsertName.TabIndex = 1;
            this.lblInsertName.Text = "Name";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(425, 57);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(237, 56);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert Employee";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.Controls.Add(this.btnDeleteEmp);
            this.tabPageDelete.Controls.Add(this.textBoxDeleteEmpId);
            this.tabPageDelete.Controls.Add(this.lblDeleteEmpId);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 25);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDelete.Size = new System.Drawing.Size(784, 188);
            this.tabPageDelete.TabIndex = 1;
            this.tabPageDelete.Text = "Delete";
            this.tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.Location = new System.Drawing.Point(446, 51);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(199, 71);
            this.btnDeleteEmp.TabIndex = 2;
            this.btnDeleteEmp.Text = "Delete Employee";
            this.btnDeleteEmp.UseVisualStyleBackColor = true;
            this.btnDeleteEmp.Click += new System.EventHandler(this.btnDeleteEmp_Click);
            // 
            // textBoxDeleteEmpId
            // 
            this.textBoxDeleteEmpId.Location = new System.Drawing.Point(233, 75);
            this.textBoxDeleteEmpId.Name = "textBoxDeleteEmpId";
            this.textBoxDeleteEmpId.Size = new System.Drawing.Size(113, 22);
            this.textBoxDeleteEmpId.TabIndex = 1;
            // 
            // lblDeleteEmpId
            // 
            this.lblDeleteEmpId.AutoSize = true;
            this.lblDeleteEmpId.Location = new System.Drawing.Point(115, 80);
            this.lblDeleteEmpId.Name = "lblDeleteEmpId";
            this.lblDeleteEmpId.Size = new System.Drawing.Size(87, 17);
            this.lblDeleteEmpId.TabIndex = 0;
            this.lblDeleteEmpId.Text = "Employee ID";
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.Controls.Add(this.btnShowEmp);
            this.tabPageUpdate.Controls.Add(this.btnUpdate);
            this.tabPageUpdate.Controls.Add(this.lblUpdateDept);
            this.tabPageUpdate.Controls.Add(this.lblUpdateSalary);
            this.tabPageUpdate.Controls.Add(this.lblUpdateName);
            this.tabPageUpdate.Controls.Add(this.textBoxUpdateDept);
            this.tabPageUpdate.Controls.Add(this.textBoxUpdateSalary);
            this.tabPageUpdate.Controls.Add(this.textBoxUpdateName);
            this.tabPageUpdate.Controls.Add(this.textBoxUpdateEmpId);
            this.tabPageUpdate.Controls.Add(this.lblUpdateEmpId);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 25);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Size = new System.Drawing.Size(784, 188);
            this.tabPageUpdate.TabIndex = 2;
            this.tabPageUpdate.Text = "Update";
            this.tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(451, 106);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(188, 60);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update Employee";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblUpdateDept
            // 
            this.lblUpdateDept.AutoSize = true;
            this.lblUpdateDept.Location = new System.Drawing.Point(83, 149);
            this.lblUpdateDept.Name = "lblUpdateDept";
            this.lblUpdateDept.Size = new System.Drawing.Size(64, 17);
            this.lblUpdateDept.TabIndex = 7;
            this.lblUpdateDept.Text = "Dept No.";
            // 
            // lblUpdateSalary
            // 
            this.lblUpdateSalary.AutoSize = true;
            this.lblUpdateSalary.Location = new System.Drawing.Point(83, 104);
            this.lblUpdateSalary.Name = "lblUpdateSalary";
            this.lblUpdateSalary.Size = new System.Drawing.Size(48, 17);
            this.lblUpdateSalary.TabIndex = 6;
            this.lblUpdateSalary.Text = "Salary";
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.Location = new System.Drawing.Point(83, 66);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(45, 17);
            this.lblUpdateName.TabIndex = 5;
            this.lblUpdateName.Text = "Name";
            // 
            // textBoxUpdateDept
            // 
            this.textBoxUpdateDept.Location = new System.Drawing.Point(233, 144);
            this.textBoxUpdateDept.Name = "textBoxUpdateDept";
            this.textBoxUpdateDept.Size = new System.Drawing.Size(100, 22);
            this.textBoxUpdateDept.TabIndex = 4;
            // 
            // textBoxUpdateSalary
            // 
            this.textBoxUpdateSalary.Location = new System.Drawing.Point(233, 99);
            this.textBoxUpdateSalary.Name = "textBoxUpdateSalary";
            this.textBoxUpdateSalary.Size = new System.Drawing.Size(100, 22);
            this.textBoxUpdateSalary.TabIndex = 3;
            // 
            // textBoxUpdateName
            // 
            this.textBoxUpdateName.Location = new System.Drawing.Point(233, 61);
            this.textBoxUpdateName.Name = "textBoxUpdateName";
            this.textBoxUpdateName.Size = new System.Drawing.Size(100, 22);
            this.textBoxUpdateName.TabIndex = 2;
            // 
            // textBoxUpdateEmpId
            // 
            this.textBoxUpdateEmpId.Location = new System.Drawing.Point(233, 22);
            this.textBoxUpdateEmpId.Name = "textBoxUpdateEmpId";
            this.textBoxUpdateEmpId.Size = new System.Drawing.Size(100, 22);
            this.textBoxUpdateEmpId.TabIndex = 1;
            // 
            // lblUpdateEmpId
            // 
            this.lblUpdateEmpId.AutoSize = true;
            this.lblUpdateEmpId.Location = new System.Drawing.Point(83, 25);
            this.lblUpdateEmpId.Name = "lblUpdateEmpId";
            this.lblUpdateEmpId.Size = new System.Drawing.Size(87, 17);
            this.lblUpdateEmpId.TabIndex = 0;
            this.lblUpdateEmpId.Text = "Employee ID";
            // 
            // btnTotalEmp
            // 
            this.btnTotalEmp.Location = new System.Drawing.Point(53, 31);
            this.btnTotalEmp.Name = "btnTotalEmp";
            this.btnTotalEmp.Size = new System.Drawing.Size(133, 40);
            this.btnTotalEmp.TabIndex = 2;
            this.btnTotalEmp.Text = "Total Employee Count";
            this.btnTotalEmp.UseVisualStyleBackColor = true;
            this.btnTotalEmp.Click += new System.EventHandler(this.btnTotalEmp_Click);
            // 
            // lblTotalEmp
            // 
            this.lblTotalEmp.AutoSize = true;
            this.lblTotalEmp.Location = new System.Drawing.Point(99, 90);
            this.lblTotalEmp.Name = "lblTotalEmp";
            this.lblTotalEmp.Size = new System.Drawing.Size(0, 17);
            this.lblTotalEmp.TabIndex = 3;
            // 
            // btnShowEmp
            // 
            this.btnShowEmp.Location = new System.Drawing.Point(451, 21);
            this.btnShowEmp.Name = "btnShowEmp";
            this.btnShowEmp.Size = new System.Drawing.Size(188, 62);
            this.btnShowEmp.TabIndex = 4;
            this.btnShowEmp.Text = "Show Employee Details";
            this.btnShowEmp.UseVisualStyleBackColor = true;
            this.btnShowEmp.Click += new System.EventHandler(this.btnShowEmp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalEmp);
            this.Controls.Add(this.btnTotalEmp);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageInsert.ResumeLayout(false);
            this.tabPageInsert.PerformLayout();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageInsert;
        private System.Windows.Forms.TextBox textBoxInsertDept;
        private System.Windows.Forms.TextBox textBoxInsertSalary;
        private System.Windows.Forms.TextBox textBoxInsertName;
        private System.Windows.Forms.Label lblInsertDept;
        private System.Windows.Forms.Label lblInsertSalary;
        private System.Windows.Forms.Label lblInsertName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.Button btnDeleteEmp;
        private System.Windows.Forms.TextBox textBoxDeleteEmpId;
        private System.Windows.Forms.Label lblDeleteEmpId;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUpdateDept;
        private System.Windows.Forms.Label lblUpdateSalary;
        private System.Windows.Forms.Label lblUpdateName;
        private System.Windows.Forms.TextBox textBoxUpdateDept;
        private System.Windows.Forms.TextBox textBoxUpdateSalary;
        private System.Windows.Forms.TextBox textBoxUpdateName;
        private System.Windows.Forms.TextBox textBoxUpdateEmpId;
        private System.Windows.Forms.Label lblUpdateEmpId;
        private System.Windows.Forms.Button btnTotalEmp;
        private System.Windows.Forms.Label lblTotalEmp;
        private System.Windows.Forms.Button btnShowEmp;
    }
}

