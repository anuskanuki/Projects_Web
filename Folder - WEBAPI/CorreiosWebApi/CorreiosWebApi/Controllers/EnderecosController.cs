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
using CorreiosWebApi.Models;

namespace CorreiosWebApi.Controllers
{
    public class EnderecosController : ApiController
    {
        private EnderecoContextDB db = new EnderecoContextDB();

        // GET: api/Enderecos
        public IQueryable<Endereco> GetEnderecos()
        {
            return db.Enderecos;
        }


        [HttpGet]
        [Route("Api/Enderecos/{cep}/InfoCep")]
        public IQueryable<Endereco> EnderecosPorCep(string cep)
        {
            return db.Enderecos.Where(x => x.Cep == cep);
        }


        [HttpGet]
        [Route("Api/Enderecos/{bairro}/InfoBairro")]
        public IQueryable<Endereco> EnderecosPorBairro(string bairro)
        {
            return db.Enderecos.Where(x => x.Bairro == bairro);
        }

        [HttpGet]
        [Route("Api/Enderecos/{logradouro}/InfoLogradouro")]
        public IQueryable<Endereco> EnderecosPorLogradouro(string logradouro)
        {
            return db.Enderecos.Where(x => x.Logradouro == logradouro);
        }

        [HttpGet]
        [Route("Api/Enderecos/{uf}/InfoUf")]
        public IQueryable<Endereco> EnderecosPorUf(string uf)
        {
            return db.Enderecos.Where(x => x.Uf == uf);
        }

        [HttpGet]
        [Route("Api/Enderecos/{municipio}/InfoMunicipio")]
        public IQueryable<Endereco> EnderecosPorMunicipio(string municipio)
        {
            return db.Enderecos.Where(x => x.Municipio == municipio);
        }

        [HttpGet]
        [Route("Api/Enderecos/{complemento}/InfoUf")]
        public IQueryable<Endereco> EnderecosPorComplemento(string complemento)
        {
            return db.Enderecos.Where(x => x.Complemento  == complemento);
        }

        // GET: api/Enderecos/5
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult GetEndereco(int id)
        {
            Endereco endereco = db.Enderecos.Find(id);
            if (endereco == null)
            {
                return NotFound();
            }

            return Ok(endereco);
        }

        // PUT: api/Enderecos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEndereco(int id, Endereco endereco)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != endereco.Id)
            {
                return BadRequest();
            }

            db.Entry(endereco).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnderecoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok("Update realizado com sucesso!"); //StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Enderecos
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult PostEndereco(Endereco endereco)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Enderecos.Add(endereco);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = endereco.Id }, endereco);
        }

        // DELETE: api/Enderecos/5
        [ResponseType(typeof(Endereco))]
        public IHttpActionResult DeleteEndereco(int id)
        {
            Endereco endereco = db.Enderecos.Find(id);
            if (endereco == null)
            {
                return NotFound();
            }

            db.Enderecos.Remove(endereco);
            db.SaveChanges();

            return Ok(endereco);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EnderecoExists(int id)
        {
            return db.Enderecos.Count(e => e.Id == id) > 0;
        }
    }
}