# Triangle Drawing Program

## Instructions for Running the Program

1. Open **Visual Studio** or any C# IDE of your choice.
2. Copy and paste the code from the provided source file into the IDE.
3. Compile and run the program.
4. Follow the on-screen instructions to input the desired triangle size.

## Tasks Performed by the Program

The program draws two types of triangles using the `#` symbol:
1. **Ascending triangle**: Starts with one `#` and increases in size to the specified height.
2. **Descending triangle**: Starts at the full height and decreases in size down to one `#`.

The program ensures only valid positive integer inputs are accepted and notifies the user in case of invalid input.

## Description of the Program

This program prompts the user to input a positive integer value representing the size of the triangle. It then generates two visual patterns:

1. An **ascending triangle**, which starts with a single `#` and grows in size line-by-line up to the specified height.
2. A **descending triangle**, which starts at the full height with `#` symbols and reduces to a single `#`.

If the input is invalid or not greater than zero, an error message is displayed, and the program terminates.

### Key Aspects

- **Input validation**: Ensures that the size of the triangle is a positive integer.
- **Dynamic pattern creation**: The triangles are drawn based on user input.
- **Error handling**: Provides clear feedback for invalid inputs.


### Step-by-Step Explanation:

1. The user is prompted to input the triangle size.
   - If the input is invalid or not greater than zero, the program displays an error message and terminates.
2. If the input is valid:
   - **Ascending triangle**:
     - Uses nested `for` loops to dynamically generate the pattern by incrementing the number of `#` symbols in each subsequent line.
   - **Descending triangle**:
     - Uses nested `for` loops to dynamically generate the pattern by decrementing the number of `#` symbols in each subsequent line.

### Program Structure:

- **Input Handling**:
  - The size is read using `Console.ReadLine()` and validated using `int.TryParse`.
  - Checks that the input is greater than zero before proceeding.

- **Pattern Drawing**:
  - **Ascending triangle**: The outer loop iterates over the height, while the inner loop determines the number of `#` symbols in each line.
  - **Descending triangle**: The outer loop iterates over the height, while the inner loop reduces the number of `#` symbols in each line.

- **Error Handling**:
  - Ensures the user enters valid positive integers. Displays an appropriate message for invalid inputs.

## Program Logic Summary

This triangle drawing program effectively demonstrates fundamental programming concepts such as loops, input validation, and dynamic output generation. The patterns are simple yet versatile, making the program a great introduction to nested loops and user-defined outputs.
