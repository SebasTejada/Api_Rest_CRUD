using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WebApi.Contexts;
using WebApi.Entities;

namespace WebApi.Controllers
{
    public class UsuarioController : ApiController
    {
        private readonly AppDbContext context;
        public UsuarioController(AppDbContext context)
        {
            this.context = context;  
        }
       
        // GET api/<controller>
        public IEnumerable<Usuario> Get()
        {
            return context.Usuario.ToList();
        }
      
        // GET api/<controller>/5
        public Usuario Get(string id)
        {
            var usuario = context.Usuario.FirstOrDefault(p=>p.id_usuario==id);
            return usuario;
        }

        // POST api/<controller>
      
        public ActionResult Post([FromBody] Usuario usuario)
        {
            try
            {
            context.Usuario.Add(usuario);
            context.SaveChanges();
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
            
        }
       
        // PUT api/<controller>/5
        public ActionResult Put(string id, [FromBody] Usuario usuario)
        {
            if(usuario.id_usuario==id)
            {
                context.Entry(usuario).State = EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }

        // DELETE api/<controller>/5
       
        public ActionResult Delete(string id)
        {
            var usuario = context.Usuario.FirstOrDefault(p => p.id_usuario == id);
            if(usuario != null)
            {
                context.Usuario.Remove(usuario);
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}