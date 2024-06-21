# GameOfLife

## The User Story

As a player I would like to play the game of life by creating a seed to see how it evolves over multiple iterations so that I can look for patterns resulting from my seed.

## Refinement

### What is the Game of Life?

In 1970, John Horton Conway created a zero-player game of cellular automation called life or [Game of Life](https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life). By zero-player we mean that given a starting position the game proceeds by evolution, not further input. Each 'move' in the game is the application of a set of rules to the existing position to generate a new one. The game is infinite, in that we can keep iterating. Patterns can emerge that are stable during these iterations.

### The Rules of the Game of Life

The board is a two-dimensional grid of cells. Each cell has a state of either *alive* or *dead*.

With each iteration, we apply the following rules to determine the state of any cell.

1. Any live cell with two or three live neighbours survives.
2. Any dead cell with three live neighbours becomes a live cell.
3. All other live cells die in the next generation. Similarly, all other dead cells stay dead.

The initial pattern is called the *seed*. When a *tick* occurs, the rules are applied and we move from *seed* to *first generation* to *second generation* and so on.

Technically the board it is infinite, but for our purposes we will treat it as finite, and treat any cell location outside the border as *dead* for evaluation purposes. No life exists outside our 'universe.'

### The Seed

The *seed* is an arbitary grid of cells.

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


### The Tick

The results of a *tick* are a new grid of cells, in the same format as the *seed* but with a generation indicator.

```
Generation 1:
4 8
........
...**...
...**...
........
```






