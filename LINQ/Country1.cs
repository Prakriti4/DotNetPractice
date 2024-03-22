using System;
using System.Linq; 
using System.Collections.Generic;

namespace LINQ 
{ 
    class Country1{ 
     static void Main(string[] args)
     { 
        void LearnLinqOnComplexCollection()
        { 
           
            Country1 c1 = new Country1("Nepal","Kathmandu", "Asia",3234234123);
            Country1 c2 = new Country1("India","Delhi", "Asia",94234123,DateTime.Parse("1947/8/9"));
            Country1 c3 = new Country1("China","Beijing", "Asia",63234234123);
            Country1 c4 = new Country1("Russia","Moscow", "Europe",454234123,DateTime.Parse("1342/2/9"));
            Country1 c5 = new Country1("Australia","Canberra", "Australia",9834234123,DateTime.Parse("1047/8/2"));
             Country1 c6 = new Country1("England","UK", "Europe",102323);
            List<Country> countries = new List<Country>{c1,c2,c3,c4,c5,c6};
            
            //List all asian countries name
            var result1 = from country in countries where country.Continent=="Asia"
            select country.Name;
            //List all asian countries which are never been invaded
            var result2= from country in countries where country.Date==null && country.Continent== "Asia"
            select country.Name;
            //List all european countries which population is less than 500k
            var result4 =from country in countries where country.Continent=="Europe"&&country.Population<500000 orderby country.Name select country;
        }
     }
    }
}