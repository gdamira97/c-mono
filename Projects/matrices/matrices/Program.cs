using System;
using System.Collections.Generic;

namespace matrices
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Matrix matrix = new Matrix();
			matrix.all();
		}
}
	class Matrix
	{
		public void all()
		{
			double[,] m = new double[3, 3] { { 2, 0, 0 }, { 1, 1, 0 }, { 4, 6, 1 } };
			double[] b = new double[3] { 1, 1, 1 };
			double[,] mt = transpose(m);
			double[,] mtm = multiply(mt, m);
			double d = determinant(mtm);
			double[,] n = inverse(mtm, d);
			double[,] q = multiply(n, mt);
			double[] xm = multbyvector(q, b);
			Console.WriteLine("m:\n");
			for (int i = 0; i < m.GetLength(0); i++)
			{
				for (int j = 0; j < m.GetLength(1); j++)
				{
					Console.WriteLine(m[i, j] + " ");
				}
				Console.WriteLine();
			}
			//double x = xm[0] + 1;
			//double y = xm[1] + 1;
			//double z = xm[2] + 1;
			Console.WriteLine(xm[0] + " " + xm[1] + " " + xm[2]);
		}
		public double[,] transpose(double[,] m)
		{
			double[,] mt = new double[m.GetLength(1), m.GetLength(0)];
			for (int row = 0; row < mt.GetLength(0); row++)
			{
				for (int col = 0; col < mt.GetLength(1); col++)
				{
					mt[row, col] = m[col, row];
				}
			}
			return mt;
		}
		public double[,] multiply(double[,] a, double[,] b)
		{
			double temp = 0;
			double[,] multiplied = new double[a.GetLength(0), b.GetLength(1)];
			if (a.GetLength(0) == b.GetLength(1))
			{
				for (int i = 0; i < a.GetLength(0); i++)
				{
					for (int j = 0; j < b.GetLength(1); j++)
					{
						temp = 0;
						for (int k = 0; k < a.GetLength(1); k++)
						{
							temp += a[i, k] * b[k, j];
						}
						multiplied[i, j] = temp;
					}
				}
			}
			return multiplied;
		}
		public double[] multbyvector(double[,] m, double[] v)
		{
			double[] r = new double[v.Length];
			double temp = 0;
			for (int i = 0; i < m.GetLength(0); i++)
			{
				temp = 0;
				for (int k = 0; k < m.GetLength(1); k++)
				{
					temp += m[i, k] * v[k];
				}
				r[i] = temp;
			}
			return r;
		}
		public double determinant(double[,] array)
		{
			double det = 0;
			double total = 0;
			double[,] tempArr = new double[array.GetLength(0) - 1, array.GetLength(1) - 1];
			if (array.GetLength(0) == 1)
			{
				det = array[0, 0];
			}
			else if (array.GetLength(0) == 2)
			{
				det = array[0, 0] * array[1, 1] - array[0, 1] * array[1, 0];
			}
			else {
				for (int i = 0; i < 1; i++)
				{
					for (int j = 0; j < array.GetLength(1); j++)
					{
						if (j % 2 != 0) array[i, j] = array[i, j] * -1;
						tempArr = minor(array, i, j);
						det += determinant(tempArr);
						total = total + (det * array[i, j]);
					}
				}
			}
			return det;
		}
		public double[,] inverse(double[,] m, double d)
		{
			double[,] r = new double[m.GetLength(0), m.GetLength(1)];
			for (int i = 0; i < m.GetLength(0); i++)
			{
				for (int j = 0; j < m.GetLength(1); j++)
				{
					r[i, j] = (determinant(minor(m, i, j)) * Math.Pow(-1, i + j)) / d;
				}
			}
			return r;
		}
		public double[,] minor(double[,] m, int r, int c)
		{
			List<List<double>> arr = new List<List<double>>();
			double[,] array = new double[m.GetLength(0) - 1, m.GetLength(1) - 1];
			for (int i = 0; i < m.GetLength(0); i++)
			{
				List<double> row = new List<double>();
				for (int j = 0; j < m.GetLength(1); j++)
				{
					row.Add(m[i, j]);
				}
				arr.Add(row);
			}
			arr.RemoveAt(r);
			foreach (List<double> row in arr)
			{
				row.RemoveAt(c);
			}
			for (int j = 0; j < array.GetLength(1); j++)
			{
				int k = 0;
				foreach (List<double> row in arr)
				{
					array[k, j] = row[j];
					k++;
				}
			}
			return array;
		}
	}
	}
