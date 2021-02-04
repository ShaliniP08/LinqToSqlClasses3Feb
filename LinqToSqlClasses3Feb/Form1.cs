using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSqlClasses3Feb
{
    public partial class Form1 : Form
    {
		EmployeeDataContext dml = new EmployeeDataContext();
		public Form1()
		{
			InitializeComponent();
		}
	
		private void ShowEmp()
		{
			var empTab = from e1 in dml.EmployeeTabs
						 select e1;
			dataGridView1.DataSource = empTab;
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			ShowEmp();
		}

        private void btnDeleteEmp_Click(object sender, EventArgs e)
        {
			var delEmp = dml.EmployeeTabs.Single(p => p.EmpId == Convert.ToInt32(textBoxDeleteEmpId.Text));
			dml.EmployeeTabs.DeleteOnSubmit(delEmp);
			dml.SubmitChanges();
			ShowEmp();
		}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
			var updateEmp = dml.sp_UpdateEmp(Convert.ToInt32(textBoxUpdateEmpId.Text),
											Convert.ToString(textBoxUpdateName.Text),
											Convert.ToSingle(textBoxUpdateSalary.Text),
											Convert.ToInt32(textBoxUpdateDept.Text));
			dataGridView1.DataSource = updateEmp;

			ShowEmp();
		}

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
			var insertEmp = dml.sp_InsertEmployee(Convert.ToString(textBoxInsertName.Text),
				Convert.ToSingle(textBoxInsertSalary.Text), Convert.ToInt32(textBoxInsertDept.Text));
			dataGridView1.DataSource = insertEmp;
			ShowEmp();
		}

        private void btnTotalEmp_Click(object sender, EventArgs e)
        {
			int? count = 0;
			dml.sp_WithOutputParameter(ref count);
			lblTotalEmp.Text += count.ToString();
			
		}

		private void btnShowEmp_Click(object sender, EventArgs e)
		{
			var empDetails = dml.sp_ShowEmpDetails(Convert.ToInt32(textBoxUpdateEmpId.Text));
			dataGridView1.DataSource = empDetails;

		}
    }
}
