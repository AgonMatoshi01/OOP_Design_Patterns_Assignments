using System;

class Program
{
    static void Main()
    {
        var generator = new WebsiteGenerator();

        Console.WriteLine("Creating portfolio website:");
        var portfolioWebsite = generator.GeneratePortfolioWebsite();
        portfolioWebsite.Display();

        Console.WriteLine("\nCreating business website:");
        var businessWebsite = generator.GenerateBusinessWebsite();
        businessWebsite.Display();
    }
}
