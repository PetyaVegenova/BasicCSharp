using ZOO.Enums;

namespace ZOO.AbstractClasses
{
    public abstract class Worker
    {
        public Worker(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public WorkerType Type { get; protected set; }
    }
}
