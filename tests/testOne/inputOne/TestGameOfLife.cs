using TDD_Rediscovered_AI_Pairing.resultOne;
using Xunit;

namespace TDD_Rediscovered_AI_Pairing.testOne.inputOne;

public class TestGameOfLifeOne
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
    
    [Fact]
    public void When_Two_Cells_Have_Insufficient_Neighbors_They_Die()
    {
        //arrange
        var seed = new Board(0, new string[3, 3]
        {
            {".", "*", "."},
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
    
    [Fact]
    public void When_A_Cells_Has_Sufficient_Neighbors_It_Lives()
    {
        //arrange
        var seed = new Board(0, new string[3, 3]
        {
            {".", ".", "*"},
            {".", "*", "."},
            {"*", ".", "."}
        });
        
        var expectedGenerationOne = new Board(1, new string[3, 3]
        {
            {".", ".", "."},
            {".", "*", "."},
            {".", ".", "."}
        }); 

        //act
        var generationOne = seed.Tick();
        
        //assert
        Assert.Equal(expectedGenerationOne, generationOne); 
    }
    
    [Fact]
    public void When_A_Cell_Has_Three_Neighbors_It_Lives_Four_Live_Neighbors_It_Dies()
    {
        //arrange
        var seed = new Board(0, new string[3, 3]
        {
            {".", "*", "."},
            {"*", "*", "*"},
            {".", "*", "."}
        });
        
        var expectedGenerationOne = new Board(1, new string[3, 3]
        {
            {"*", "*", "*"},
            {"*", ".", "*"},
            {"*", "*", "*"}
        }); 

        //act
        var generationOne = seed.Tick();
        
        //assert
        Assert.Equal(expectedGenerationOne, generationOne); 
    }
    
    [Fact]
    public void When_A_Cell_Has_Is_At_The_Edge_It_Has_Dead_Neighbors()
    {
        //arrange
        var seed = new Board(0, new string[3, 3]
        {
            {"*", "*", "*"},
            {"*", ".", "*"},
            {"*", "*", "*"}
        });
        
        var expectedGenerationOne = new Board(1, new string[3, 3]
        {
            {"*", ".", "*"},
            {".", ".", "."},
            {"*", ".", "*"}
        }); 

        //act
        var generationOne = seed.Tick();
        
        //assert
        Assert.Equal(expectedGenerationOne, generationOne); 
    } 
}