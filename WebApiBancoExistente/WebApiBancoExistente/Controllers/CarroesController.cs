using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiBancoExistente;

namespace WebApiBancoExistente.Controllers
{
    public partial class CarroesController : ApiController
    {
        private DbContextCarros db = new DbContextCarros();

        //[HttpGet]
        //[Route("Api/Carroes/CustomQuery")]
        //public object CustomCarrosQuery()
        //{
        //    var listaDeCarros = db.Carros.ToList();//trazer todos os carros em lista
        //    var retornoCarros = from cr
        //                        in listaDeCarros
        //                        select new
        //                        {
        //                            NomeCarro = cr.Modelo,
        //                            CarroId = cr.Id
        //                        };

        //    return retornoCarros;
        //}


        //[HttpGet]
        //[Route("Api/Carroes/CustomCarrosMarcas")]
        //public object CustomCarrosMarcas()
        //{
        //    var listaDeCarros = db.Carros.ToList();
        //    var listaDeMarcas = db.Marcas.ToList();

        //    var conteudoRetorno = from mar in listaDeMarcas
        //                          join car in listaDeCarros
        //                          on mar.Id equals car.Marca
        //                          select new
        //                          {
        //                              CarroId = car.Id,
        //                              CarroNome = car.Modelo,
        //                              MarcaId = mar.Id,
        //                              MarcaNome = mar.Nome
        //                          };
        //    return conteudoRetorno;

        //}



        //[HttpGet]
        //[Route("Api/Carroes/UsuIns")]
        //public object UsuarioQueInseriuOcarro(int idCarro)
        //{
        //    var listaDeCarros = db.Carros.Where(p => p.Id == idCarro).ToList();
        //    var listaDeUsuarios = db.Usuarios.ToList();

        //    var conteudoRetorno = from usu in listaDeUsuarios
        //                          join car in listaDeCarros
        //                           on usu.Id equals car.UsuInc
        //                          select new
        //                          {
        //                              IdUsuario = usu.Id,
        //                              DataInclusao = car.DatInc,
        //                              UsuarioQueIncluiu=usu.Usuario1
        //                          };
        //    return conteudoRetorno;

        //}


        // GET: api/Carroes
        public IQueryable<Carro> GetCarros()
        {
            return db.Carros;
        }

        // GET: api/Carroes/5
        [ResponseType(typeof(Carro))]
        public IHttpActionResult GetCarro(int id)
        {
            Carro carro = db.Carros.Find(id);
            if (carro == null)
            {
                return NotFound();
            }

            return Ok(carro);
        }

        // PUT: api/Carroes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCarro(int id, Carro carro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != carro.Id)
            {
                return BadRequest();
            }

            db.Entry(carro).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarroExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Carroes
        [ResponseType(typeof(Carro))]
        public IHttpActionResult PostCarro(Carro carro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }



            db.Carros.Add(carro);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = carro.Id }, carro);
        }

        // DELETE: api/Carroes/5
        [ResponseType(typeof(Carro))]
        public IHttpActionResult DeleteCarro(int id)
        {
            Carro carro = db.Carros.Find(id);
            if (carro == null)
            {
                return NotFound();
            }

            db.Carros.Remove(carro);
            db.SaveChanges();

            return Ok(carro);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CarroExists(int id)
        {
            return db.Carros.Count(e => e.Id == id) > 0;
        }
    }
}