using TDD_Rediscovered_AI_Pairing.resultOne;
using Xunit;

namespace TDD_Rediscovered_AI_Pairing.testTwo.inputOne;

public class TestGameOfLifeTwo
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
}