using RestWithASPNET.Model;

namespace RestWithASPNET.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<Person> FindAll()
        {
          var persons = new List<Person>();

            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        private Person MockPerson(int id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Wesley" + id,
                LastName = "Tapajoz" + id,
                Address = "Várze-Grande MT Brasil" + id,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Wesley",
                LastName = "Tapajoz",
                Address = "Várze-Grande MT Brasil",
                Gender = "Male"
            };
        }

        public Person Updte(Person name)
        {
            throw new NotImplementedException();
        }
    }
}
