# Duplicate Character Remover

This console application removes duplicate characters from a user-provided word and outputs the result. It preserves the order of the first occurrence of each character.

## Features

- Removes duplicate characters from input
- Preserves the original order of characters
- Simple and interactive command-line interface

## Requirements

- .NET SDK (version 6.0 or later recommended)

## Getting Started

# Copy Code from here

```
using System.Text;

Console.WriteLine("Enter a World");
string str = Console.ReadLine();
if (string.IsNullOrEmpty(str))
{
    Console.WriteLine("Input cannot be null or empty.");
    return;
}

bool[] seen = new bool[256];
StringBuilder sb = new StringBuilder();
for (int i = 0; i < str.Length; i++)
{
    if (!seen[str[i]])
    {
        seen[str[i]] = true;
        sb.Append(str[i]);
    }
}

Console.WriteLine(sb.ToString());

```

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/kaleemiqbal4/duplicate-character-remover.git
   ```
