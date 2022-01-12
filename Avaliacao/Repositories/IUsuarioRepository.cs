using Avaliacao.Model;
using System.Collections.Generic;


namespace Avaliacao.Repositories
{
    public interface IUsuarioRepository
    {
        void Adicionar(Usuario usuario);

        void Atualizar(Usuario usuario);

        IEnumerable<Usuario> Buscar();

        Usuario Buscar(int idUsuario);

    }
}
