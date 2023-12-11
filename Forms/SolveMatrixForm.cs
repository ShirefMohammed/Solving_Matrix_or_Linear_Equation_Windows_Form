using System;
using System.Text;

namespace Matrix_Solver_Form.Forms
{
	public partial class SolveMatrixForm : Form
	{
		float[,] matrix;
		int changes = 0;
		TextBox textBox;

		public SolveMatrixForm(float[,] matrix)
		{
			InitializeComponent();
			this.matrix = matrix;
		}

		private void SolveMatrixForm_Load(object sender, EventArgs e)
		{
			textBox = new TextBox();
			textBox.Multiline = true;
			textBox.ReadOnly = true;
			textBox.ScrollBars = ScrollBars.Vertical;
			textBox.Dock = DockStyle.Fill;
			this.Controls.Add(textBox);

			PrintMatrix(matrix);
			string solution = SolveMatrix(matrix);

			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"=========================== Matrix Solution ============================");
			sb.AppendLine(solution);
			textBox.Text += sb.ToString();
		}

		// Solve Matrix Function
		private string SolveMatrix(float[,] matrix)
		{
			// loop on diagonal items from top to bottom to convert items under diagonal to zeros
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				/*
					check if current item matrix[i, i] of diagonal items equal 0
					then swap current row with another one from under rows
					to make matrix[i, i] not equal 0
				*/
				if (matrix[i, i] == 0)
				{
					/*
						get second row index j and check if matrix[j, i] != 0 make swap 
						else check the next one and so on
						else if all column items equal zeros then No or Many solutions
					 */
					int j = i + 1;

					while (true)
					{
						if (j == matrix.GetLength(0))
						{
							if (matrix[i, matrix.GetLength(1) - 1] != 0)
								return "Matrix has no solutions";
							else
								return "Matrix has many solutions";
						}

						if (matrix[j, i] != 0)
						{
							SwapTwoRowsOfMatrix(matrix, i, j);
							PrintMatrix(matrix);
							break;
						}

						j++;
					}
				}

				/*
					make loop under matrix[i, i] in same column
					and check if matrix[j, i] == 0 then continue
					else make matrix[j, i] equal 0 by the next operations
				*/
				for (int j = i + 1; j < matrix.GetLength(0); j++)
				{
					if (matrix[j, i] == 0)
					{
						continue;
					}
					else
					{
						float x = (-1 * matrix[j, i]) / matrix[i, i];
						for (int z = 0; z < matrix.GetLength(1); z++)
						{
							matrix[j, z] = matrix[j, z] + (x * matrix[i, z]);
						}

						PrintMatrix(matrix);
					}
				}
			}

			/* 
				check if n > m + 1 then will be no or many solutions
				already we check if it has no solutions then now it has many solutions
			*/
			if (matrix.GetLength(1) > matrix.GetLength(0) + 1)
				return "Matrix has many solutions";

			// loop on diagonal items from bottom to top to convert items up diagonal to zeros
			for (int i = matrix.GetLength(0) - 1; i > 0; i--)
			{
				/*
					make loop up matrix[i, i] in same column
					and check if matrix[j, i] == 0 then continue
					else make matrix[j, i] equal 0 by the next operations
				*/
				for (int j = i - 1; j >= 0; j--)
				{
					if (matrix[j, i] == 0)
					{
						continue;
					}
					else
					{
						float x = (-1 * matrix[j, i]) / matrix[i, i];
						for (int z = 0; z < matrix.GetLength(1); z++)
						{
							matrix[j, z] = matrix[j, z] + (x * matrix[i, z]);
						}

						PrintMatrix(matrix);
					}
				}
			}

			// loop on rows to make diagonal items equal 1
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				if (matrix[i, i] == 1)
				{
					continue;
				}
				else
				{
					matrix[i, matrix.GetLength(1) - 1] = matrix[i, matrix.GetLength(1) - 1] / matrix[i, i];
					matrix[i, i] = 1;

					PrintMatrix(matrix);
				}
			}

			// return the solution of the matrix
			string solution = "(";
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				solution += matrix[i, matrix.GetLength(1) - 1];

				if (i != matrix.GetLength(0) - 1)
					solution += ", ";
			}
			solution += ")";

			return solution;
		}

		private void SwapTwoRowsOfMatrix(float[,] matrix, int firstRowIndex, int secondRowIndex)
		{
			for (int i = 0; i < matrix.GetLength(1); i++)
			{
				float temp = matrix[firstRowIndex, i];
				matrix[firstRowIndex, i] = matrix[secondRowIndex, i];
				matrix[secondRowIndex, i] = temp;

				// another way for swapping => tuple way
				// (matrix[secondRowIndex, i], matrix[firstRowIndex, i]) = (matrix[firstRowIndex, i], matrix[secondRowIndex, i]);
			}
		}

		private void PrintMatrix(float[,] matrix)
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine($"===================== Change Number {changes++} =========================");

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					sb.Append(matrix[i, j] + "\t");
				}

				sb.AppendLine();
			}

			sb.AppendLine();
			textBox.Text += sb.ToString();
		}

		// Close form
		private void SolveMatrixForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			ReadMatrixForm readMatrixForm = new ReadMatrixForm(matrix.GetLength(0), matrix.GetLength(1));
			this.Hide();
			readMatrixForm.Show();
		}
	}
}
