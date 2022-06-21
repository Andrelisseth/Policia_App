using Policia_App.Models;
using Policia_App.Service;
using Microsoft.AspNetCore.Mvc;

namespace Policia_App.Controllers
{

    public class PersonaController : Controller
    {

        private IPersona PersonaIntercafe;
        
        public PersonaController(IPersona persona)
        {
            PersonaIntercafe = persona;            
        }

        public IActionResult Delete(int id)
        {
            Persona es = new Persona();
            es.IdPersona = id;
            PersonaIntercafe.DeletePersonas(es);

            return RedirectToAction("Index");
        }

        public IActionResult Load(int id)
        {
            Persona es = new Persona();
            es.IdPersona = id;
            var listarPersonas = PersonaIntercafe.LoadInformation(es);

            return View(listarPersonas);
        }

        public IActionResult actu(Persona es)
        {
                    
            PersonaIntercafe.UpdatePersonas(es);
            return RedirectToAction("Index");

        }

        public IActionResult Guardar()
        {

            return View();
        }
        
        public IActionResult Save(Persona es)
        {

            PersonaIntercafe.AddPersonas(es);
            return RedirectToAction("Index");

        }

        public IActionResult Index()
        {
            var listar = PersonaIntercafe.GetAll();

            return View(listar);
        }


        [HttpPost]
        public IActionResult Insertardata(Persona es)
        {

            return RedirectToAction("Index");
            // return View("Index");

        }
    }
}
