using Avaliacao.Model;
using System;
using System.Collections.Generic;


namespace Avaliacao.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        public void Adicionar(Usuario usuario)
        {
           
        }

        public void Atualizar(Usuario usuario)
        {
            
        }

        public IEnumerable<Usuario> Buscar()
        {
            return new List<Usuario>();
        }

        public Usuario Buscar(int idUsuario)
        {
            return new Usuario();
        }
    }
}
