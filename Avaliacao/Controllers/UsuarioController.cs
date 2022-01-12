using Avaliacao.Model;
using Avaliacao.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Avaliacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
      



        // GET: api/<UsuarioController>
        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            Usuario usuarios = new Usuario();

            return usuarios.listaUsuario();
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public Usuario Get(int id)
        {
            Usuario usuarios = new Usuario();

            return usuarios;
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public List<Usuario> Post(Usuario usuario)
        {
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(usuario);

            return usuarios;

        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
