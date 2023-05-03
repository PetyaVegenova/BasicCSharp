using static System.Formats.Asn1.AsnWriter;

namespace ContestScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var participants = new List<Participant>() 
            {
                new Participant("Peter", 2, "KLM123"), 
                new Participant("Vlad", 4, "KLM1234"), 
                new Participant("Tudor", 9, "KLM1239"), 
                new Participant("Irina", 1, "KLM1231"), 
                new Participant("Neo", 10, "KLM12310"),
            };

            //Add a new participant with score to the end of the list
            var participant = new Participant("Dany", 3, "DY80");

            participants.Add(participant);

            //Delete a participant from a given position.
            participants.RemoveAt(participants.Count-1);

            //Add a new participant with score to a position given in the list.
            participants.Insert(3, participant);

            //Modify the score of a participant by identification number.
            var participantById = participants.FirstOrDefault(e => e.IdNumber == "KLM1231");
            participantById.Score = 8;

            //Print all participants that have a score less that a given score
            Console.WriteLine("Participants with score less then 7");
            foreach (var participantItem in participants.Where(e => e.Score < 7))
            {
                Console.WriteLine($"{participantItem.Name} - {participantItem.Score}");
            }
            Console.WriteLine("--------------");

            //Print all the participants in ascending order by score.
            Console.WriteLine("Participants ordered by score ascending");
            foreach (var participantItem in participants.OrderBy(e => e.Score))
            {
                Console.WriteLine($"{participantItem.Name} - {participantItem.Score}");
            }
            Console.WriteLine("--------------");

            //Print all the participants with a score bigger than a given score in ascending order by score.
            Console.WriteLine("Participants with score more then 6, ordered by score ascending");
            foreach (var participantItem in participants.Where(e => e.Score > 6).OrderBy(e => e.Score))
            {
                Console.WriteLine($"{participantItem.Name} - {participantItem.Score}");
            }
            Console.WriteLine("--------------");

            //Calculate the arithmetic mean of the scores for a given interval.
            Console.WriteLine("Aritmetic mean for interval 1 to 4");
            Console.WriteLine(AritmeticMean(participants, 1, 4));
            Console.WriteLine("--------------");

            Console.WriteLine("Aritmetic mean for interval 2 to 5");
            Console.WriteLine(AritmeticMean(participants, 2, 5));
            Console.WriteLine("--------------");
        }

        static double AritmeticMean(List<Participant> participants, int startPosition, int endPosition) 
        {
            var scoreSum = 0.0;
            var partisipantsCount = 0.0;

            for (int i = startPosition; i <= endPosition; i++)
            {
                scoreSum += participants[i].Score;
                partisipantsCount++;
            }
            return scoreSum / partisipantsCount;
        }
    }
}