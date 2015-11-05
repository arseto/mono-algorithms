using System;

namespace Algorithms
{
	public class PascalTriangle
	{
		private int _size;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="Algorithms.PascalTriangle"/> class.
		/// </summary>
		/// <param name='v_Size'>
		/// triangle size (height)
		/// </param>
		public PascalTriangle(int v_Size)
		{
			_size = v_Size;
		}
		/// <summary>
		/// Computes the pascal triangle item, uses recursion
		/// </summary>
		/// <returns>
		/// The item.
		/// </returns>
		/// <param name='level'>
		/// Level.
		/// </param>
		/// <param name='idx'>
		/// Index.
		/// </param>
		public static int ComputeElementValue(int rowIndex, int elementIndex)
		{
			if(elementIndex == 0) return 1;
			if(elementIndex == rowIndex) return 1;
			return ComputeElementValue(rowIndex-1, elementIndex-1) + ComputeElementValue(rowIndex-1, elementIndex);
		}

		/// <summary>
		/// Generates the triangle.
		/// </summary>
		/// <returns>
		/// The triangle formed in one dimensional string array, one line represented in one array item
		/// </returns>
		public string[] GenerateTriangleStr()
		{
			string[] result = new string[_size];
			int[][] items = GenerateTriangleArray();
			
			string spacer = createSpacer();
			for(int i=0;i<items.Length;i++)
			{
				string temp = spacer.Substring(i+1);
				for(int j=0;j<items[i].Length;j++)
				{
					temp+=items[i][j]+"  ";
				}
				result[i] = temp;
			}
			return result;
		}
		
		public static string[] GenerateTriangleStr(int startRow, int endRow)
		{
			string[] result = new string[endRow-startRow];
			int[][] items = GenerateTriangleArray(startRow,endRow);
			
			string spacer = createSpacer(endRow-startRow);
			for(int i=0;i<items.Length;i++)
			{
				string temp = spacer.Substring(i+1);
				for(int j=0;j<items[i].Length;j++)
				{
					temp+=items[i][j]+"  ";
				}
				result[i] = temp;
			}
			return result;
		}
		
		private static string createSpacer(int size)
		{
			string result = "";
			for (int i=0;i<size;i++)
			{
				result+=" ";
			}
			return result;
		}
		
		private string createSpacer()
		{
			return createSpacer(_size);
		}
		
		/// <summary>
		/// Computes the line.
		/// </summary>
		/// <returns>
		/// The line.
		/// </returns>
		/// <param name='level'>
		/// zero-based level
		/// </param>
		public static int[] GenerateLine (int rowIndex)
		{
			int[] result = new int[rowIndex+1];
            for(int elementIndex = 0; elementIndex <= rowIndex; elementIndex++)
			{
				result[elementIndex] = ComputeElementValue(rowIndex,elementIndex);
			}
			return result;
		}

		/// <summary>
		/// Generates the triangle array.
		/// </summary>
		/// <returns>
		/// /// Pascal triangle in form of two dimensional int array
		/// </returns>
		public int[][] GenerateTriangleArray()
		{
			int[][] result = new int[_size][];
			for(int i=0;i<_size;i++)
			{
				result[i] = GenerateLine (i);
			}
			return result;
		}
		
		public static int[][] GenerateTriangleArray(int startRow, int endRow)
		{
			int[][] result = new int[endRow-startRow][];
			for(int i=startRow;i<endRow;i++)
			{
				result[i] = GenerateLine (i);
			}
			return result;
		}
	}
}

