namespace Matrix_Solver_Form
{
	partial class HomeForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			ColumnsNumberInput = new NumericUpDown();
			RowsNumberInput = new NumericUpDown();
			label3 = new Label();
			CreateMatrixBtn = new Button();
			((System.ComponentModel.ISupportInitialize)ColumnsNumberInput).BeginInit();
			((System.ComponentModel.ISupportInitialize)RowsNumberInput).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(74, 27);
			label1.Name = "label1";
			label1.Size = new Size(168, 28);
			label1.TabIndex = 0;
			label1.Text = "Matrix Solver";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 85);
			label2.Name = "label2";
			label2.Size = new Size(56, 16);
			label2.TabIndex = 2;
			label2.Text = "Columns";
			// 
			// ColumnsNumberInput
			// 
			ColumnsNumberInput.Location = new Point(74, 83);
			ColumnsNumberInput.Name = "ColumnsNumberInput";
			ColumnsNumberInput.Size = new Size(231, 21);
			ColumnsNumberInput.TabIndex = 3;
			// 
			// RowsNumberInput
			// 
			RowsNumberInput.Location = new Point(74, 117);
			RowsNumberInput.Name = "RowsNumberInput";
			RowsNumberInput.Size = new Size(231, 21);
			RowsNumberInput.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 119);
			label3.Name = "label3";
			label3.Size = new Size(35, 16);
			label3.TabIndex = 4;
			label3.Text = "Rows";
			// 
			// CreateMatrixBtn
			// 
			CreateMatrixBtn.Location = new Point(15, 153);
			CreateMatrixBtn.Name = "CreateMatrixBtn";
			CreateMatrixBtn.Size = new Size(290, 23);
			CreateMatrixBtn.TabIndex = 6;
			CreateMatrixBtn.Text = "Create Matrix";
			CreateMatrixBtn.UseVisualStyleBackColor = true;
			CreateMatrixBtn.Click += CreateMatrixBtn_Click;
			// 
			// HomeForm
			// 
			AutoScaleDimensions = new SizeF(7F, 16F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(317, 211);
			Controls.Add(CreateMatrixBtn);
			Controls.Add(RowsNumberInput);
			Controls.Add(label3);
			Controls.Add(ColumnsNumberInput);
			Controls.Add(label2);
			Controls.Add(label1);
			Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
			Name = "HomeForm";
			Text = "Form1";
			FormClosed += HomeForm_FormClosed;
			((System.ComponentModel.ISupportInitialize)ColumnsNumberInput).EndInit();
			((System.ComponentModel.ISupportInitialize)RowsNumberInput).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private NumericUpDown ColumnsNumberInput;
		private NumericUpDown RowsNumberInput;
		private Label label3;
		private Button CreateMatrixBtn;
	}
}