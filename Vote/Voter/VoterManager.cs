using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vote.Candidate;

namespace Vote.Voter
{
    public class VoterManager
    {
        private List<IVoter> voters = new List<IVoter>();

        public void AddVoter(IVoter voter)
        {
            voters.Add(voter);
        }

        public void DisplayAllVoters()
        {
            foreach (var voter in voters)
            {
                Console.WriteLine(voter.ToString());
            }
        }

        public void VoterSignUp()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid input. Name cannot be null or empty.");
                return;
            }

            IVoter newVoter = new SingleVoter(name);

            AddVoter(newVoter);
        }

        public bool HasVoters()
        {
            return voters.Count > 0;
        }
    }
}


