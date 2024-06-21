namespace TDD_Rediscovered_AI_Pairing;

public class Board
{
    public int Generation { get; }
    public string[,] Grid { get; }

    public Board(int generation, string[,] grid)
    {
        Generation = generation;
        Grid = grid;
    }

    public Board Tick()
    {
        int rows = Grid.GetLength(0);
        int cols = Grid.GetLength(1);
        string[,] newGrid = new string[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                int liveNeighbors = CountLiveNeighbors(row, col);
                if (Grid[row, col] == "*" && (liveNeighbors == 2 || liveNeighbors == 3))
                {
                    newGrid[row, col] = "*";
                }
                else if (Grid[row, col] == "." && liveNeighbors == 3)
                {
                    newGrid[row, col] = "*";
                }
                else
                {
                    newGrid[row, col] = ".";
                }
            }
        }

        return new Board(Generation + 1, newGrid);
    }

    private int CountLiveNeighbors(int row, int col)
    {
        int[] dRows = { -1, -1, -1, 0, 1, 1, 1, 0 };
        int[] dCols = { -1, 0, 1, 1, 1, 0, -1, -1 };
        int liveNeighbors = 0;

        for (int i = 0; i < 8; i++)
        {
            int newRow = row + dRows[i];
            int newCol = col + dCols[i];

            if (newRow >= 0 && newRow < Grid.GetLength(0) && newCol >= 0 && newCol < Grid.GetLength(1))
            {
                if (Grid[newRow, newCol] == "*")
                {
                    liveNeighbors++;
                }
            }
        }

        return liveNeighbors;
    }

    public override bool Equals(object obj)
    {
        if (obj is Board other)
        {
            if (Generation != other.Generation)
                return false;

            for (int row = 0; row < Grid.GetLength(0); row++)
            {
                for (int col = 0; col < Grid.GetLength(1); col++)
                {
                    if (Grid[row, col] != other.Grid[row, col])
                        return false;
                }
            }

            return true;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return (Generation, Grid).GetHashCode();
    }
}