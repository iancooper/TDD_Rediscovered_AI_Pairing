using TDD_Rediscovered_AI_Pairing.resultTwo.roundOne;
using Xunit;

namespace TDD_Rediscovered_AI_Pairing.testTwo.inputOne.roundOne;

public class TestGameOfLifeThree
{
    [Fact]
    public void When_All_The_Cells_Are_Dead_No_Change()
    {
        //arrange
        var seed = new Board(0, new string[3, 3]
        {
            {".", ".", "."},
            {".", ".", "."},
            {".", ".", "."}
        });
        
        var expectedGenerationOne = new Board(1, new string[3, 3]
        {
            {".", ".", "."},
            {".", ".", "."},
            {".", ".", "."}
        }); 

        //act
        var generationOne = seed.Tick();
        
        //assert
        Assert.Equal(expectedGenerationOne, generationOne);
    }
    
    [Fact]
    public void When_A_Single_Cell_Has_No_Neighbors_It_Dies()
    {
        //arrange
        var seed = new Board(0, new string[3, 3]
        {
            {".", ".", "."},
            {".", "*", "."},
            {".", ".", "."}
        });
        
        var expectedGenerationOne = new Board(1, new string[3, 3]
        {
            {".", ".", "."},
            {".", ".", "."},
            {".", ".", "."}
        }); 

        //act
        var generationOne = seed.Tick();
        
        //assert
        Assert.Equal(expectedGenerationOne, generationOne); 
    }
}