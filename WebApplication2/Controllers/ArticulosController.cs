using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Datos;
using System.Linq;
using System.Data.Entity;

namespace WebApplication2.Controllers
{
    public class ArticulosController : ApiController
    {
        // GET: api/Articulos
        public List<Articulos> Get()
        {
            using (PymesEntities db = new PymesEntities())
            {
                return db.Articulos.ToList();
            }
        }

        // GET: api/Articulos/5
        public IHttpActionResult Get(int id)
        {
            using (PymesEntities db = new PymesEntities())
            {
                IQueryable<Articulos> list = from Articulos in db.Articulos
                                             select Articulos;

                Articulos articulo = list.Where(x => x.IdArticulo == id).FirstOrDefault();

                if (articulo != null)
                {
                    return Ok(articulo);

                }
                else
                {
                    return NotFound();
                }
            }
        }

        // POST: api/Articulos
        public IHttpActionResult Post([FromBody] Articulos articulo)
        {
            using (PymesEntities db = new PymesEntities())
            {
                if (ModelState.IsValid)
                {
                    db.Articulos.Add(articulo);
                    db.SaveChanges();
                    return Ok(articulo);
                }
                else
                {
                    return BadRequest();
                }

            }
        }

        // PUT: api/Articulos/5
        public IHttpActionResult Put(int id, [FromBody]Articulos articulo)
        {
            using (PymesEntities db = new PymesEntities())
            {
                if (ModelState.IsValid)
                {
                    var articuloExiste = db.Articulos.Count(x => x.IdArticulo == id) > 0;

                    if (articuloExiste)
                    {
                        db.Entry(articulo).State = EntityState.Modified;
                        db.SaveChanges();
                        return Ok();
                    }else
                    {
                        return NotFound();
                    }

                }
                else
                {
                    return BadRequest();

                }

            }
        }

        // DELETE: api/Articulos/5
        public IHttpActionResult Delete(int id)
        {
            using (PymesEntities db = new PymesEntities())
            {
                Articulos articulo = db.Articulos.Where(x => x.IdArticulo == id).FirstOrDefault();

                if (articulo != null)
                {
                    db.Articulos.Remove(articulo);
                    db.SaveChanges();
                    return Ok(articulo);
                }
                else
                {
                    return NotFound();
                }
            }
        }
    }
}
