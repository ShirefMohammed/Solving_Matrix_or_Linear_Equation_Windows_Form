using System;
using System.Drawing.Drawing2D;

namespace Matrix_Solver_Form.Forms
{
	public partial class ReadMatrixForm : Form
	{
		int m, n;
		int TEXTBOX_WIDTH = 40;
		int TEXTBOX_HEIGHT = 40;
		int SPACING = 10;
		List<List<NumericUpDown>> cells = new List<List<NumericUpDown>>();

		public ReadMatrixForm(int m, int n)
		{
			InitializeComponent();

			// Get Matrix Row and Columns m*n
			this.m = m;
			this.n = n;
		}

		// Add Matrix Cells
		private void ReadMatrixForm_Load(object sender, EventArgs e)
		{
			Panel panel = new Panel();

			for (int row = 0; row < m; row++)
			{
				List<NumericUpDown> newRow = new List<NumericUpDown>();
				cells.Add(newRow);

				for (int col = 0; col < n; col++)
				{
					NumericUpDown cell = new NumericUpDown();
					cell.Width = TEXTBOX_WIDTH;
					cell.Height = TEXTBOX_HEIGHT;
					cell.Top = (row * (TEXTBOX_HEIGHT)) + SPACING;
					cell.Left = (col * (TEXTBOX_WIDTH + SPACING)) + SPACING;
					cell.Maximum = Convert.ToDecimal(int.MaxValue);
					cell.Minimum = Convert.ToDecimal(int.MinValue);
					newRow.Add(cell);
					panel.Controls.Add(cell);
				}
			}

			panel.Dock = DockStyle.Fill;
			this.Controls.Add(panel);
			this.Controls.SetChildIndex(panel, 0);

			// Create Solve Matrix button
			Button SolveMatrixBtn = new Button();
			SolveMatrixBtn.Text = "Solve Matrix";
			SolveMatrixBtn.Click += SolveMatrix; // Solve the Problem
			SolveMatrixBtn.Dock = DockStyle.Bottom;

			this.Controls.Add(SolveMatrixBtn);
			this.Controls.SetChildIndex(SolveMatrixBtn, 1);
		}

		// Read and Send Matrix to solveMatrixForm
		private void SolveMatrix(object sender, EventArgs e)
		{
			float[,] matrix = new float[m, n];

			// Read matrix from cells and put them in matrix
			for (int row = 0; row < m; row++)
			{
				for (int col = 0; col < n; col++)
				{
					matrix[row, col] = (float)cells[row][col].Value;
				}
			}

			SolveMatrixForm solveMatrixForm = new SolveMatrixForm(matrix);
			this.Hide();
			solveMatrixForm.Show();
		}

		// Close form
		private void ReadMatrixForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			HomeForm homeForm = new HomeForm();
			this.Hide();
			homeForm.Show();
		}
	}
}
