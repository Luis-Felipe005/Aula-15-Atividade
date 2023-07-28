using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aula15Atividade
{
    internal class Cliente
    {

        public string nome;
        public int idade;
        public Usuario usuario;

        public Cliente(string nome, int idade, Usuario usuario)
        {

         this.nome = nome;
         this.idade = idade;
         this.usuario = usuario;

        }


    }
}
