using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_123tarde
{
    public class Cliente
    {
        public int Id;
        public string Nome;
        public string Telefone;



        public Cliente(int id, string nome, string telefone)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;

        }
        public int getId()
        {
            return Id;
        }
        public string getNome()
        {
            return Nome;
        }
        public string getTelefone()
        {
            return Telefone;
        }

        public void setId(int id)
        {
           Id = id;
        }

        public void setNome(string nome)
        {
            Nome = nome;
        }

        public  void setTelefone(string telefone)
        {
            Telefone = telefone;
        }


    }
}
