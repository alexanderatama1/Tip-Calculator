// Declare amount and tip percentage variables
decimal amount, tip;

do
{
    Console.Clear();
    // Print Header
    Console.WriteLine("Tip Calculator");
    Console.WriteLine("===============");

    // Prompt for amount & tip
    Console.WriteLine("Enter amount: ");
    amount = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Enter tip: ");
    tip = decimal.Parse(Console.ReadLine());

    // Clear screen
    Console.Clear();

    // Print result with tip amount in green
    Console.Write($"A {tip:p0} tip on {amount:c}: is ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{(tip * amount):c}");

    // Reset Color
    Console.ResetColor();
    Console.Write(" Go again? (Y/N): ");
    if (Console.ReadLine().ToUpper() != "Y")
    {
        break;
    }
} while (true);