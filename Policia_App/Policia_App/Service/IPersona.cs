using Policia_App.Models;

namespace Policia_App.Service
{
    public interface IPersona
    {

        public void AddPersonas(Persona es);

        public void UpdatePersonas(Persona es);
        public void DeletePersonas(Persona es);

        public List<Persona> GetAll();

        public Persona LoadInformation(Persona es);

    }
}
