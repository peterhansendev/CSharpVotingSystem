using Vote.Voter;

namespace Vote.Candidate
{
    public class CandidateManager
    {
        private List<ICandidate> candidates = new List<ICandidate>();

        public void AddCandidate(ICandidate candidate)
        {
            candidates.Add(candidate);
        }

        public void DisplayAllCandidates()
        {
            foreach (var candidate in candidates)
            {
                Console.WriteLine(candidate.ToString());
            }
        }

        public ICandidate GetCandidateByName(string name)
        {
            return candidates.Find(candidate => candidate.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void SignUp()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter party");
            string party = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(party))
            {
                Console.WriteLine("Invalid input. Name and party cannot be null or empty.");
                return;
            }

            ICandidate newCandidate = new SingleCandidate(name, party);

            AddCandidate(newCandidate);
        }

        public void Vote()
        {
            Console.WriteLine("Choose a candidate to vote for (Enter candidate name):");
            string name = Console.ReadLine();

            ICandidate chosenCandidate = GetCandidateByName(name);

            if (chosenCandidate != null)
            {
                chosenCandidate.IncrementNumVotes();
                Console.WriteLine($"You voted for {chosenCandidate.Name}");
            }
            else
            {
                Console.WriteLine($"Candidate with name {name} not found.");
            }
        }
        public bool HasCandidates()
        {
            return candidates.Count > 0;
        }
    }
}