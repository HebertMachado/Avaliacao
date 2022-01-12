using System;
using System.Collections.Generic;

namespace Avaliacao.Model
{
   
    public class Usuario
    {
       

        public int idUsuario { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public Int64 Telefone { get; private set; }
        public DateTime dataNascimento { get; private set; }
        public string cpf { get; private set; }

        public List<Usuario> listaUsuario()
        {
            Usuario usuarios = new Usuario();
            usuarios.idUsuario = 1;
            usuarios.Nome = "Marta";
            usuarios.Email = "joao@teste.com.br";
            usuarios.Senha = "12345";
            usuarios.Telefone = 33816148;
            usuarios.cpf = "00112365478";

            List<Usuario> listaUsuario = new List<Usuario>();
            listaUsuario.Add(usuarios);

            return listaUsuario;
            




        }

    }
}
