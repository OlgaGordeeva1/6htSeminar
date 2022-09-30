// 11 12 13 14
// 21 22 23 24
// 31 32 33 34
// 41 42 43 44

// 11 12 13 14 21 22 23 24 31 32 33 34 41 42 43 44 row-col
// 11 21 31 41 12 22 32 42 13 23 33 43 14 24 34 44 col-row

int[,] CreateArray(int row, int col)
{
  return new int[row, col];
}

void Fill(int[,] array)
{
  int rows = array.GetLength(0), cols = array.GetLength(1);

  for (int row = 0; row < rows; row++)
  {
    for (int col = 0; col < cols; col++)
    {
      array[row, col] = Random.Shared.Next(10);
    }
  }
}

int PrintRowCol(int[,] array)
{
  int s = 0;
  int rows = array.GetLength(0), cols = array.GetLength(1);
  for (int row = 0; row < rows; row++)
  {
    for (int col = 0; col < cols; col++)
    {
      Console.Write($"{array[row, col],3}");
      s += array[row, col];
    }
    //Console.WriteLine();
  }
  return s;
}

int PrintColRow(int[,] array)
{
  int s = 0;
  int rows = array.GetLength(0), cols = array.GetLength(1);
  for (int col = 0; col < cols; col++)
  {
    for (int row = 0; row < rows; row++)
    {
      Console.Write($"{array[row, col],3}");
      s += array[row, col];
    }
    // Console.WriteLine();
  }
  return s;
}

int[,] table = CreateArray(3, 4);
Fill(table);
PrintRowCol(table);
Console.WriteLine();
PrintColRow(table);

// System.Console.WriteLine();

// DateTime dts = DateTime.Now;
// Console.WriteLine($"PrintRowCol(table): {PrintRowCol(table)}");
// DateTime dte = DateTime.Now;
// System.Console.WriteLine((dte - dts).TotalMilliseconds);

// System.Console.WriteLine();

// dts = DateTime.Now;
// Console.WriteLine($"PrintColRow(table): {PrintColRow(table)}");
// dte = DateTime.Now;
// System.Console.WriteLine((dte - dts).TotalMilliseconds);
// System.Console.WriteLine();
