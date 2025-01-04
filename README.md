# C# Uninitialized Property Bug

This repository demonstrates a potential pitfall in C# related to uninitialized properties.  When you access a property of a class before assigning a value to it, C# will not throw an exception. Instead, it will return the default value for the property's type.

This behavior can lead to unexpected results and subtle bugs if not carefully considered.  The example code showcases this issue and provides a solution.

## Bug
The `Bug.cs` file contains code that illustrates the problem. The `MyProperty` is accessed within `MyMethod` before it's given a value.  This results in an unexpected output. 

## Solution
The `BugSolution.cs` file presents a solution to the problem.  Explicit initialization prevents unexpected default value usage.

## How to Reproduce
1. Clone this repository.
2. Open `Bug.cs` in your preferred C# IDE.
3. Run the code. Observe the output (it will be 0).
4. Open `BugSolution.cs`. Observe how initialization prevents the issue.