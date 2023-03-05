using System;

using System.Collections.Generic;
using System.Linq;

namespace UniqueEmailAddresses
{
    public static class UniqueEmailAddresses
    {
        static int NumberOfUniqueEmailAddresses(List<string> emails)
        {
            HashSet<string> uniqueEmails = new HashSet<string>();
            foreach (string email in emails)
            {
                string[] parts = email.Split('@');
                string localPart = parts[0];
                string domainName = parts[1];

                // Apply rules for periods and plus symbols in local-part
                localPart = localPart.Replace(".", "");
                if (localPart.Contains("+"))
                {
                    localPart = localPart.Substring(0, localPart.IndexOf("+"));
                }

                // Add the modified email address to the HashSet
                uniqueEmails.Add(localPart + "@" + domainName);
            }

            foreach (string email in uniqueEmails)
            {
                Console.WriteLine(email);
            }

            return uniqueEmails.Count;
        }

        static void Main(string[] args)
        {

            // Example list of strings
            List<string> strings = new List<string>() { "hello", "world", "how", "are", "you" };

            // Concatenate the list of strings into a single string
            string concatenatedString = string.Join(" ", strings);

            // Read the concatenated string from console input
            Console.WriteLine("Please enter the list of strings:");
            string input = Console.ReadLine();

            // Split the input string back into individual strings
            List<string> inputStrings = input.Split(' ').ToList();

            NumberOfUniqueEmailAddresses(inputStrings);
        }
    }
}