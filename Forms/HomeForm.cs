using Matrix_Solver_Form.Forms;

namespace Matrix_Solver_Form
{
	public partial class HomeForm : Form
	{
		public HomeForm()
		{
			InitializeComponent();
		}

		// Get m, n then Open readMatrixForm
		private void CreateMatrixBtn_Click(object sender, EventArgs e)
		{
			int m = (int)ColumnsNumberInput.Value;
			int n = (int)RowsNumberInput.Value;

			if (m == 0 || n == 0)
			{
				MessageBox.Show("min columns and rows is 1");
				return;
			}

			if (m > 15 || n > 15)
			{
				MessageBox.Show("max columns and rows is 15");
				return;
			}

			ReadMatrixForm readMatrixForm = new ReadMatrixForm(m, n);
			this.Hide();
			readMatrixForm.Show();
		}

		// Exist Application
		private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}