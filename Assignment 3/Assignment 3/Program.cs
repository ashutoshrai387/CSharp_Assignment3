class Program
{
    static void Main(string[] args)
    {
        // Dictionary with prime ministers and years
        Dictionary<int, string> primeMinisters = new Dictionary<int, string>()
        {
            { 1998, "Atal Bihari Vajpayee" },
            { 2014, "Narendra Modi" },
            { 2004, "Manmohan Singh" }
        };

        // Prime minister of 2004
        int yearToFind = 2004;
        if (primeMinisters.ContainsKey(yearToFind))
        {
            Console.WriteLine($"The Prime Minister of {yearToFind} was: {primeMinisters[yearToFind]}");
        }
        else
        {
            Console.WriteLine($"No Prime Minister found for the year {yearToFind}");
        }

        // Add the current prime minister in dictionary
        int currentYear = DateTime.Now.Year;
        string currentPrimeMinister = "Narendra Modi"; 
        primeMinisters[currentYear] = currentPrimeMinister;

        // Sort dictionary by year
        var sortedPrimeMinisters = primeMinisters.OrderBy(kv => kv.Key);

        Console.WriteLine("\nPrime Ministers sorted by year:");
        foreach (var kvp in sortedPrimeMinisters)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}