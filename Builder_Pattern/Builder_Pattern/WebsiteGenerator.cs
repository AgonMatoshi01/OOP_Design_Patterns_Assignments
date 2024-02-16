using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WebsiteGenerator
{
    public Website GeneratePortfolioWebsite()
    {
        var website = new Website();
        website.AddComponent(new Homepage());
        website.AddComponent(new AboutPage());
        website.AddComponent(new ContactForm());
        website.AddComponent(new Gallery());
        return website;
    }

    public Website GenerateBusinessWebsite()
    {
        var website = new Website();
        website.AddComponent(new Homepage());
        website.AddComponent(new AboutPage());
        website.AddComponent(new ContactForm());
        website.AddComponent(new Gallery());
        website.AddComponent(new Blog());
        return website;
    }
}