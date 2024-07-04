
namespace TDD_Rediscovered_AI_Pairing.resultTwo.roundOne;

public class Board
{
    private int _generation;
    private string[,] _cells;

    public Board(int generation, string[,] cells)
    {
        _generation = generation;
        _cells = cells;
    }

    public Board Tick()
    {
        return new Board(_generation + 1, _cells);
    }

    public override bool Equals(object obj)
    {
        if (obj is Board other)
        {
            if (_generation != other._generation)
            {
                return false;
            }

            for (int i = 0; i < _cells.GetLength(0); i++)
            {
                for (int j = 0; j < _cells.GetLength(1); j++)
                {
                    if (_cells[i, j] != other._cells[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        return false;
    }

    public override int GetHashCode()
    {
        int hash = _generation;
        foreach (var cell in _cells)
        {
            hash = hash * 31 + (cell?.GetHashCode() ?? 0);
        }
        return hash;
    }
}