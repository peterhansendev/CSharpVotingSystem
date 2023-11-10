namespace Vote.Candidate
{
    public class SingleCandidate : ICandidate
    {
        public string Name { get; }
        public string Party { get; }
        public int NumVotes { get; private set; }

        public SingleCandidate(string name, string party)
        {
            Name = name;
            Party = party;
        }

        public void IncrementNumVotes()
        {
            NumVotes += 1;
        }

        public override string ToString()
        {
            return $"{Name} {Party} {NumVotes}";
        }
    }
}