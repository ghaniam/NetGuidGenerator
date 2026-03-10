using GuidGenerator.Core;

Console.WriteLine("GUID Generator Application");
Console.WriteLine("==========================");
Console.WriteLine();

while (true)
{
    Console.Write("Enter the number of GUIDs to generate (or 'exit' to quit): ");
    var input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Input cannot be empty. Please try again.");
        Console.WriteLine();
        continue;
    }

    if (input.Trim().Equals("exit", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Goodbye!");
        break;
    }

    if (!int.TryParse(input, out int count))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        Console.WriteLine();
        continue;
    }

    try
    {
        var guidGenerator = new GuidGeneratorService();
        var guids = guidGenerator.GenerateGuids(count);

        Console.WriteLine();
        Console.WriteLine($"Generated {guids.Count} GUID(s):");
        Console.WriteLine(new string('-', 50));

        for (int i = 0; i < guids.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {guids[i]}");
        }

        Console.WriteLine();
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
        Console.WriteLine();
    }
}
