namespace Matrix_Solver_Form.Forms
{
	partial class SolveMatrixForm
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
			SuspendLayout();
			// 
			// SolveMatrixForm
			// 
			AutoScaleDimensions = new SizeF(9F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(781, 471);
			Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4, 4, 4, 4);
			Name = "SolveMatrixForm";
			Text = "SolveMatrixForm";
			FormClosed += SolveMatrixForm_FormClosed;
			Load += SolveMatrixForm_Load;
			ResumeLayout(false);
		}

		#endregion
	}
}