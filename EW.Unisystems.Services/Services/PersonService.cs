using EW.Unisystems.Data.Repositories;

namespace EW.Unisystems.Services.Services
{
    public class PersonService
    {
        private PersonRepository _personRepository;

        public PersonService()
        {
            _personRepository = new PersonRepository();
        }

    }
}