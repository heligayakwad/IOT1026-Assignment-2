namespace Assignment
{
    /// <summary>
    /// Represents the main program class.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The entry point of the program.
        /// </summary>
        static void Main()
        {
            // Display a greeting message
            System.Console.WriteLine("Hello World");

            // Create a new treasure chest with specific properties
            TreasureChest chest = new TreasureChest(TreasureChest.Material.Oak, TreasureChest.LockType.Intermediate, TreasureChest.LootQuality.Green);

            // Display the details of the treasure chest
            Console.WriteLine(chest);
        }
    }
}
