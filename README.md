# TDD Rediscovered - ProgrammerTests

## What is this?

This is an implementation of [Conway's Game of Life](https://github.com/iancooper/GameOfLife), used to support my course: TDD Rediscovered.

It is intended to demonstrate the developer doing TDD with an AI writing the implementation.

## The Rules

The code was created using the following rules:

* We are writing [Programmer Tests](https://wiki.c2.com/?ProgrammerTest). A failing test tells us that the last edit to the source is the source of an issue

* The prompt to write a test is a new requirement. We assume that we obtained these when elaborating the story with the customer.

* When we discover that we need new collaborators by refactoring we ask: are they part of our public interface or an implementation detail. We don’t test implementation details

## LLM

- ChatGPT 4o: It could not work incrementally
- Claude Sonnet: It could work incrementally
