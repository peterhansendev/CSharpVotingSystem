namespace Vote.Candidate
{
    public interface ICandidate
    {
        string Name { get; }
        string Party { get; }
        int NumVotes { get; }

        void IncrementNumVotes();
    }
}