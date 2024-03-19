using System; 
using System.Collections.Generic;
using Microsoft.VisualBasic;
// using LearnCollections;
namespace LearnCollections
{ 
    public class Collections
    { 
        void LearnLists()
        { 
           List<byte> ages = new List<byte>{2,3};
           ages.Add(1); 
           ages.Add(20); 
           ages.Add(100);
           ages.Add(255);

           List<Country> countries = new List<Country>();
           countries.Add(new Country());

        }
      public   void LearnDictionary()
        { 
            Dictionary<string , string> countryCapitals = new Dictionary<string, string> /*();*/
            {
                ["Nepal"]="Kathmandu", 
                ["India"]="Delhi",
                ["China"]="Mosco"
            };
            // countryCapitals.Add("Nepal","Kathmandu");
            // countryCapitals.Add("India","Delhi"); 
            // countryCapitals.Add("China","Beijing");
            foreach(var country in countryCapitals)
            { 
                Console.WriteLine($"Country:{country.Key} Capital City: {country.Value}");
            }
      }
    }
    public class Country
    { 
        public string Name { get; set; }

    }
}