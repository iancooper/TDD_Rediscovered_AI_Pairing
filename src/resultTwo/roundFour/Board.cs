namespace TDD_Rediscovered_AI_Pairing.resultTwo.roundFour
{
   public class Board
   {
       private int generation;
       private string[,] cells;

       public Board(int generation, string[,] cells)
       {
           this.generation = generation;
           this.cells = cells;
       }

       public Board Tick()
       {
           int rows = this.cells.GetLength(0);
           int cols = this.cells.GetLength(1);
           string[,] newCells = new string[rows, cols];

           for (int i = 0; i < rows; i++)
           {
               for (int j = 0; j < cols; j++)
               {
                   int liveNeighbors = CountLiveNeighbors(i, j);
                   if (cells[i, j] == "*" && liveNeighbors == 2)
                   {
                       newCells[i, j] = "*";
                   }
                   else
                   {
                       newCells[i, j] = ".";
                   }
               }
           }

           return new Board(this.generation + 1, newCells);
       }

       private int CountLiveNeighbors(int row, int col)
       {
           int count = 0;
           for (int i = -1; i <= 1; i++)
           {
               for (int j = -1; j <= 1; j++)
               {
                   if (i == 0 && j == 0) continue;
                   int newRow = row + i;
                   int newCol = col + j;
                   if (newRow >= 0 && newRow < cells.GetLength(0) && newCol >= 0 && newCol < cells.GetLength(1))
                   {
                       if (cells[newRow, newCol] == "*")
                       {
                           count++;
                       }
                   }
               }
           }
           return count;
       }

       public override bool Equals(object obj)
       {
           if (obj is Board other)
           {
               return this.generation == other.generation && 
                      Enumerable.Range(0, this.cells.GetLength(0)).All(i =>
                          Enumerable.Range(0, this.cells.GetLength(1)).All(j =>
                              this.cells[i, j] == other.cells[i, j]));
           }
           return false;
       }

       public override int GetHashCode()
       {
           return HashCode.Combine(generation, cells);
       }
   }
}