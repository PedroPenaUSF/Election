using System;
using System.Collections.Generic;

namespace Election2
{
    class Program
    {
        static void Main(string[] args)
        {
            // It's a canadian election, and we are given candidate names and candidate parties
            // Write onto the console the party of the winner.
            // create two empty dictionaries, one for the candidate/party
            // the other for candidate/vote count

            Dictionary<string, string> candidatePartyDict = new Dictionary<string, string>();
            Dictionary<string, int> candidateVoteCountDict = new Dictionary<string, int>();
            int totalVotesEntries;
            // Receive the input, and each candidate and party
            // will be stored in dictionary. Key = Candidate Name | Value = Party
            // loop n times to receive candidate name and candidate party
            int amountOfCandidates = int.Parse(Console.ReadLine());

            for (int i = 0; i < amountOfCandidates; i++)
            {
                string candidateName = Console.ReadLine();
                string candidateParty = Console.ReadLine();
                candidatePartyDict.Add(candidateName, candidateParty);
            }
            // Add each candidate name into a dictionary
            // Key = candidate
            // Value = their count will be 0 to start

            foreach (var cncp in candidatePartyDict)
            {
                candidateVoteCountDict.Add(cncp.Key, 0);
            }
            // Take in second integer which is the amount of votes.
            
                totalVotesEntries = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < totalVotesEntries; i++)
            {
                string entry = Console.ReadLine();
                // check if candidate is dictionary, if not just ignore it
                if (candidateVoteCountDict.ContainsKey(entry))
                {
                    candidateVoteCountDict[entry] += 1;
                }
                continue;
            }

            /* view Key Value Pairs (shows candidate/count for all candidates)
            
            foreach (var kpv in candidateVoteCountDict)
            {
                Console.WriteLine(kpv.Key + ' ' + kpv.Value);
            }*/

            // Find the highest count of votes in the vote count dictionary.
            int highestCount = 0;

            foreach (var kvp in candidateVoteCountDict)
            {               
                if(kvp.Value >= highestCount)
                {
                    highestCount = kvp.Value;
                }
            }

            // Find how many of highest count appears in the dictionary.
            // if more than 1 then it's a tie.
           

            int highestCountQty = 0;
            string winner = "";
            foreach (var kvp in candidateVoteCountDict)
            {
                if (kvp.Value == highestCount)
                {
                    highestCountQty += 1;
                    winner = kvp.Key;
                }
            }

            // print out party if not tie
            if (highestCountQty > 1)
            {
                Console.WriteLine("tie");
            }
            else
            {
                Console.WriteLine(candidatePartyDict[winner]);
 
            }
            
        }
        
    }
}