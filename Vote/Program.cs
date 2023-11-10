using System;
using Vote.Candidate;
using Vote.Voter;

namespace Vote
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            CandidateManager candidateManager = new CandidateManager();
            VoterManager voterManager = new VoterManager();

            while (true)
            {
                Console.WriteLine("Vote, Display Candidates, Go For Election, or Exit");
                userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "go":
                        candidateManager.SignUp();
                        break;
                    case "signup":
                        voterManager.VoterSignUp();
                        break;
                    case "display":
                        candidateManager.DisplayAllCandidates();
                        break;
                    case "vote":
                        if (voterManager.HasVoters() && candidateManager.HasCandidates())
                        {
                            candidateManager.DisplayAllCandidates();
                            candidateManager.Vote();
                        }
                        else
                        {
                            Console.WriteLine("No voters/candidates available. Sign up as a voter first. Type 'signup'");
                        }
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please enter 'go', 'display', 'vote', or 'exit'.");
                        break;
                }
            }
        }
    }
}

