using System;

namespace mongo_deployment_v1
{
    public class Program
    {
        public static void Main(string[] args)
        {


            string[] pizzaShops = {"Dominos", "Little Ceasers", "Pizza Hut", "Papa Johns", "Blaze Pizza", "Papa Murphys", "GodFathers", "Chuck's Blvd" };
            string searchTerm = "";

            Console.WriteLine(string.Join(",", pizzaShops));

            do
            {
                Console.WriteLine("Enter a full or partial name to search for:");
                searchTerm = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(searchTerm));

            string[] searchWords = searchTerm.Split(" ");
            int amountOfWords = searchWords.Length;


            for (int i = 0; i < amountOfWords; i++)
            {
                Console.WriteLine("Any Part of Shop Name Matching Search Terms:");
                Console.WriteLine(SearchByAnyMatch(searchWords[i]).ToString());
                Console.WriteLine("\n");
                Console.WriteLine("Start of Shop Matching Search Terms:");
                Console.WriteLine(SearchByAnyStart(searchWords[i]).ToString());
            }

            string SearchByAnyMatch(string wordToSearch)
            {
                string searchResults = "";

                foreach (string shop in pizzaShops)
                {
                    string[] shopName = shop.Split(" ");

                    foreach (string name in shopName)
                    {
                        if (name.Contains(wordToSearch, StringComparison.InvariantCultureIgnoreCase))
                        {
                            searchResults += ($"{shop}, ");
                        }
                    }


   
                }
                               
                return searchResults;
            }

            string SearchByAnyStart(string wordToSearch)
            {
                string searchResults = "";

                foreach (string shop in pizzaShops)
                {
                    string[] shopName = shop.Split(" ");

                    foreach (string name in shopName)
                    {
                        if (name.StartsWith(wordToSearch, StringComparison.InvariantCultureIgnoreCase))
                        {
                            searchResults += ($"{shop}, ");
                        }
                    }
                }

                return searchResults;
            }

        }

    }
}
