# System

You are a helpful code assistant. Your language of choice is C#. Don't explain the code, just generate the code block itself

## User

## Instructions:

1. **Author's Input**:
   - Write an XUnit test in a `.cs` file.
   - Upload the `.cs` file containing the XUnit tests to this prompt environment.

2. **Model's Tasks**:
   - Read and understand the uploaded XUnit test file.
   - Generate the C# code required to make all the tests in the file pass.
   - Only include the necessary code to pass the tests—exclude any speculative or extraneous code.

## Context:

### GameOfLife

#### The User Story

As a player I would like to play the game of life by creating a seed to see how it evolves over multiple iterations so that I can look for patterns resulting from my seed.

#### Refinement

##### What is the Game of Life?

In 1970, John Horton Conway created a zero-player game of cellular automation called life or [Game of Life](https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life). By zero-player we mean that given a starting position the game proceeds by evolution, not further input. Each 'move' in the game is the application of a set of rules to the existing position to generate a new one. The game is infinite, in that we can keep iterating. Patterns can emerge that are stable during these iterations.

##### The Rules of the Game of Life

The board is a two-dimensional grid of cells. Each cell has a state of either *alive* or *dead*.

With each iteration, we apply the following rules to determine the state of any cell.

1. Any live cell with two or three live neighbours survives.
2. Any dead cell with three live neighbours becomes a live cell.
3. All other live cells die in the next generation. Similarly, all other dead cells stay dead.

The initial pattern is called the *seed*. When a *tick* occurs, the rules are applied and we move from *seed* to *first generation* to *second generation* and so on.

Technically the board it is infinite, but for our purposes we will treat it as finite, and treat any cell location outside the border as *dead* for evaluation purposes. No life exists outside our board.

##### The Seed

The *seed* is an arbitrary grid of cells.

The first line indicates that this is a *seed*.

The first line of the seed is two integers that represent the rows and columns of the grid.

Each cell in the grid is represented by a "." character if dead and a '*" character if alive.

For example


```
Seed:
4 8 
........
....*...
...**...
........

```

##### The Tick

The results of a *tick* are a new grid of cells, in the same format as the *seed* but with a generation indicator.

```
Generation 1:
4 8
........
...**...
...**...
........
```


## Input Data:

---

**[Upload your XUnit test `.cs` file here]**

---

## ChatGPT Execution Steps:

1. **Read the Uploaded File**: Extract the content of the uploaded XUnit test file.
2. **Analyze the Tests**: Understand the specifications and requirements defined by the tests.
3. **Generate Required C# Code**:
   - Write only the code needed to make all the tests pass.
   - Ensure the code passes the tests

## Next Steps:

If this makes sense to you respond with `show me the code`