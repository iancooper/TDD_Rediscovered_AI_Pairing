namespace TDD_Rediscovered_AI_Pairing.resultTwo.roundThree
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
                   newCells[i, j] = ".";
               }
           }

           return new Board(this.generation + 1, newCells);
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