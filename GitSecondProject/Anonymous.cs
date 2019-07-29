using System;

namespace GitSecondProject
{
    public class Anonymous
    {
        public void Message(string message,Person person)
        {
            Console.WriteLine($"Hello {person.FirstName} : {message}");
        }
    }
}
