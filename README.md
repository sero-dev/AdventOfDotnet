# 🎄 Advent of Dotnet

A repository for my solutions to the Advent of Code 2024 challenges, implemented in C# using .NET.

## 📖 How It Works

Each solution is implemented in the Solutions/DayXX.cs file.
Input files for each day are stored in Input/dayXX.txt.
Run the program, choose a day, and view the results for both parts of the challenge.

## 🛠 Usage
### Prerequisites

    .NET SDK (version 9.0 or higher).

### Run the Program

1. Clone the repository:

```bash
git clone https://github.com/sero-dev/advent-of-dotnet.git
cd advent-of-dotnet
```

2. Build the project:

```bash
cd AdventOfDotnet
dotnet build
```

3. Run the application:

```bash
dotnet run
``` 

4. Follow the prompts to select the day.

### Add Solutions for New Days

Implement a new solution in the `AdventOfDotnet/Solutions/DayXX.cs` file.
Add the corresponding input file in `AdventOfDotnet/Input/dayXX.txt`.

## 🧪 Testing

The repository includes unit tests to ensure solution correctness:

1. Navigate to the test project:

```bash 
cd AdventOfCode.Tests
```

2. Run the tests:
```bash
dotnet test
```

## 🎯 Features

- Modular Design: Supports multiple days seamlessly.
- Dynamic Input Management: Automatically associates input files with their respective solutions.
- Unit Testing: Ensures accuracy of solutions.
- Scalability: Easily add new years or days as needed.

## 📝 License

This repository is licensed under the MIT License. See the LICENSE file for details.

Enjoy solving the puzzles! 🎅