
# Test-Driven Development (TDD) Prompt Template

**Objective:**

I am writing a test, and I need ChatGPT to implement the code that gets the test to pass. I want ChatGPT to only generate the minimal code required for the test to pass. As I add more tests, ChatGPT should add more code. I may also suggest refactorings that ChatGPT should perform on the code. ChatGPT should avoid adding more than the minimal code necessary to pass the test.

**Prompt:**

1. **Initial Setup:**
   - "I am starting a Test-Driven Development (TDD) session. Below is the initial test I have written. Please generate only the minimal code required to pass this test."

   ```python
   # Initial test code here
   ```

2. **Implementation of Minimal Code:**
   - "Based on the above test, please provide the minimal implementation code required to pass the test without adding any extra functionality."

3. **Adding More Tests:**
   - "Now, I have written an additional test. Please update the code by adding only the necessary minimal implementation to pass this new test as well."

   ```python
   # New test code here
   ```

4. **Refactoring:**
   - "I would like to refactor the code now. Here are my suggestions for refactoring. Please refactor the code accordingly but ensure that all existing tests continue to pass after refactoring."

   ```python
   # Refactoring suggestions here
   ```

5. **General Rules:**
   - "Always ensure that you only add the minimal code required to pass the current set of tests."
   - "Avoid adding any additional functionality beyond what is necessary to make the tests pass."
   - "If a refactoring is suggested, perform the refactoring but do not introduce new functionality."
   - "Respond with the updated code after each step."

**Example:**

1. Initial Test:
   ```python
   def test_addition():
       assert add(1, 2) == 3
   ```

2. Minimal Implementation:
   ```python
   def add(a, b):
       return a + b
   ```

3. Additional Test:
   ```python
   def test_addition_negative():
       assert add(-1, 2) == 1
   ```

4. Updated Implementation:
   ```python
   # The same `add` function should work for this new test without modification,
   # since the initial implementation is already minimal and correct.
   def add(a, b):
       return a + b
   ```

5. Refactoring Suggestion:
   ```python
   # If there is any code that needs refactoring, describe the changes here.
   # Ensure the function's behavior remains the same.
   ```
