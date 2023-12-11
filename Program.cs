namespace Matrix_Solver_Form
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new HomeForm());
		}
	}
}

/*
SOME TEST CASES
==============================================
1) => Matrix 3*4
0 2 1 −8
1 −2 −3 0
−1 1 2 3
Matrix Solution => (-4, -5, 2)
==============================================
2) => Matrix 3*4
1 2 3 9
2 −1 1 8
3 0 −1 3
Matrix Solution => (2, -1, 3)
==============================================
3) => Matrix 2*3
2 1 4
1 1 2
Matrix Solution => (2, 0)
==============================================
4) => Matrix 2*3
2 2 4
1 1 2
Matrix Solution => Matrix has many solutions
==============================================
5) => Matrix 2*3
1 1 4
2 2 6
Matrix Solution => Matrix has no solutions
==============================================
6) => Matrix 3*4
1 −2 −6 12
2 4 12 −17
1 −4 −12 22
Matrix Solution => Matrix has no solutions
==============================================
7) => Matrix 3*5
1 2 −3 1 −2
3 −1 −2 −4 1
2 3 −5 1 −3
Matrix Solution => Matrix has many solutions
==============================================
*/