using System.ComponentModel.DataAnnotations;

namespace ContestScore
{
    internal class Participant
    {
        public Participant(string name, int score, string idNumber)
        {
            Name = name;
            Score = score;
            IdNumber = idNumber;
        }

        public string Name { get; private set; }

        [Range(1,10,ErrorMessage = "Score must be between 1 and 10!")]
        public int Score { get; set; }

        public string IdNumber { get; private set; }
    }
}
