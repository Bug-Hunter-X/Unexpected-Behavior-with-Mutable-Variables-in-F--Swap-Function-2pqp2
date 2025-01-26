# F# Mutable Variable Swap Function Bug

This repository demonstrates a common error when working with mutable variables in F#. The `swap` function attempts to swap the values of two mutable variables, but it doesn't produce the expected result.

## The Bug

The `bug.fs` file contains the erroneous code.  The issue stems from the way F#'s mutable variables behave in combination with the function's parameter passing.  The `swap` function modifies copies of `x` and `y`, not the original variables. 

## The Solution

The `bugSolution.fs` file provides a corrected version of the `swap` function using a more idiomatic F# approach. It demonstrates how to correctly swap values while dealing with mutable variables.

## How to Run

1. Clone this repository.
2. Open the files in a F# editor (e.g., Visual Studio, Ionide).
3. Run the code in each file to observe the different behavior.