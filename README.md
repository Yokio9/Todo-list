# ToDo List (C# Console App)

A simple command-line TODO list application built with C#.

## Features

- View all TODO items
- Add a new TODO item
- Remove a TODO item by index
- Exit the application
- Input handling for empty, invalid, and duplicate entries

## Tech Stack

- Language: C#
- Framework: .NET 10 (`net10.0`)
- App Type: Console application

## Project Structure

```text
ToDoList/
  ToDoList.slnx
  ToDoList/
    Program.cs
    ToDoList.csproj
```

## Requirements

- .NET SDK 10.0 or later

Check your installed SDK version:

```bash
dotnet --version
```

## Run the App

From the workspace root:

```bash
dotnet run --project ToDoList
```

Or from inside the `ToDoList/` project folder:

```bash
dotnet run
```

## How to Use

When the app starts, you will see a menu:

- `[S]ee all TODOs`
- `[A]dd a TODO`
- `[R]emove a TODO`
- `[E]xit`

Type one of the letters and press Enter.

### Behavior Details

- `See`: Prints all items.
- `Add`: Rejects empty descriptions and duplicate TODO text.
- `Remove`: Shows the list first, then removes the selected valid index.
- `Exit`: Ends the program with a goodbye message.

## Notes

- Menu input is case-insensitive (`s` and `S` both work).
- TODOs are stored in memory only; they are cleared when the app closes.
