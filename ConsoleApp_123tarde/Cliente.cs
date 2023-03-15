using System;
using System.Collections.Generic;
using System.Globalization;
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
        public Endereco Endereco;



        public Cliente(int id, string nome, string telefone, Endereco endereco)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
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

        public Endereco GetEndereco()
        {
            return Endereco;
        }
        public string ExibirCliente()
        {
            return Nome + "telefone" + Telefone + Endereco.EnderecoCompleto();
        }
    }
}
