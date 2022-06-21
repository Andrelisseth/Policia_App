using Policia_App.Data;
using Policia_App.Models;
using Policia_App.Service;

namespace Policia_App.Repository
{
    public class Persona : IPersona
    {

        private PoliciaContext app;

        public Persona(PoliciaContext app)
        {
            this.app = app;
        }

        public void AddPersonas(Models.Persona es)
        {
            app.Personas.Add(es);
            app.SaveChanges();
        }

        public void DeletePersonas(Models.Persona es)
        {
            app.Personas.Remove(es);
            app.SaveChanges();
        }

        public List<Models.Persona> GetAll()
        {
            return app.Personas.ToList(); 
        }

        public Models.Persona LoadInformation(Models.Persona es)
        {
            var listarPersonas = app.Personas.Where(x => x.IdPersona == es.IdPersona).FirstOrDefault();
            return listarPersonas;
        }

        public void UpdatePersonas(Models.Persona es)
        {
            app.Personas.Update(es);
            app.SaveChanges();
        }
    }
}
