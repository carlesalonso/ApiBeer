using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using api2.Models;


namespace api2.Controllers
{
    /// <summary>
    /// Acceso a la lista de cervezas
    /// </summary>
    public class ProducteController : ApiController
    {
        static List<Producte> productes = new List<Producte>()
        {
            new Producte {Id=1,Nom="Crimbergen",Categoria="Blond Ale",Preu=2.75},
            new Producte {Id=2,Nom="Guinness",Categoria="Stout",Preu=2.50 },
            new Producte {Id=3,Nom="Timmermans",Categoria="Lambic",Preu=3.75 }
        };
        /// <summary>
        /// Retorna todas las cervezas
        /// </summary>
        /// <returns></returns>
        // GET: api/Producte
        public IEnumerable<Producte> Get()
        {
            return productes;
        }
        /// <summary>
        /// Retorna cerveza seleccionada por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/Producte/5
        public IHttpActionResult Get(int id)
        {
            
            var producte = productes.FirstOrDefault((p) => p.Id == id);
            if (producte == null)
                return NotFound();
            return Ok(producte);
            
        }

        /// <summary>
        /// Agrega nueva cerveza en la lista
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        // POST: api/Producte
        public IHttpActionResult Post(Producte value)
        {
            
                int nextId = productes.Count+1;
                value.Id = nextId;
                productes.Add(value);
            return Ok(value);
            //return CreatedAtRoute("DefaultApi", new {id = value.Id},value);
         }
        /// <summary>
        /// Modifica datos cerveza ya existente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        // PUT: api/Producte/
        public IHttpActionResult Put(int id,[FromBody]Producte value)
        {
            var producte = productes.Where(p => p.Id == id).SingleOrDefault();
            if (producte == null)
                return NotFound();
            var index = productes.IndexOf(producte);
            value.Id = id;
            productes[index] = value;
            return Ok(value);
        }
        /// <summary>
        /// Elimina cerveza de la lista
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // DELETE: api/Producte/5
        public IHttpActionResult Delete(int id)
        {
            var producte = productes.Where(p => p.Id == id).SingleOrDefault();
            if (producte == null)
                return NotFound();
            var index = productes.IndexOf(producte);
            productes.RemoveAt(index);
            return Ok();
        }
    }
}
