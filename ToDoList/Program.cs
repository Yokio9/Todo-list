string userInput;
var todoList = new List<string>();
Console.WriteLine("Hello!");

do
{
	Console.WriteLine("What do you want to do?");
	Console.WriteLine("[S]ee all TODOs");
	Console.WriteLine("[A]dd a TODO");
	Console.WriteLine("[R]emove a TODO");
	Console.WriteLine("[E]xit");

	userInput = Console.ReadLine() ?? "";

	ChoiceOutput(userInput);
} while (!IsSameLetter(userInput, "E"));

bool SeeTodos()
{
	if (todoList.Count == 0)
	{
		Console.WriteLine("No TODOs have been added yet\n");
		return false;
	}
	Console.WriteLine("TODO list:");
	for (int i = 0; i < todoList.Count; i++)
	{
		Console.WriteLine($"{i + 1}. {todoList[i]}");
	}
	Console.WriteLine("");
	return true;
}

void AddTodo()
{
	string todoItem;
	while (true)
	{
		Console.WriteLine("Enter the TODO description:");
		todoItem = Console.ReadLine() ?? "";
		if (string.IsNullOrWhiteSpace(todoItem))
			Console.WriteLine("The descitpion cannot be empty\n");
		else if (todoList.Contains(todoItem))
			Console.WriteLine("The descitpion must be unique\n");
		else
			break;
	}
	todoList.Add(todoItem);
	Console.WriteLine($"TODO successfully added: {todoItem}\n");
}

void RemoveTodo()
{
	string todoIndex;
	while (true)
	{
		if (!SeeTodos())
			return;
		Console.WriteLine("Select the index of the TODO you want to remove:");
		todoIndex = Console.ReadLine() ?? "";
		if (string.IsNullOrWhiteSpace(todoIndex))
			Console.WriteLine("Selected index cannot be empty\n");
		bool isNbr = int.TryParse(todoIndex, out int todoIndexNbr);
		if (!isNbr || todoIndexNbr > todoList.Count || todoIndexNbr < 1)
			Console.WriteLine("The given index is invalid\n");
		else
		{
			Console.WriteLine($"TODO successfully removed: {todoList[todoIndexNbr - 1]}\n");
			todoList.RemoveAt(todoIndexNbr - 1);
			break;
		}
	}
}

void ChoiceOutput(string userInput)
{
	switch (userInput)
	{
		case "s":
		case "S":
			Console.WriteLine("");
			SeeTodos();
			return;
		case "a":
		case "A":
			Console.WriteLine("");
			AddTodo();
			return;
		case "r":
		case "R":
			Console.WriteLine("");
			RemoveTodo();
			return;
		case "e":
		case "E":
			Console.WriteLine("");
			Console.WriteLine("Bye");
			return;
		default:
			Console.WriteLine("Invalid input\n");
			return;
	}
}

bool IsSameLetter(string userInput, string choice) {
	return userInput.ToUpper() == choice.ToUpper();
}