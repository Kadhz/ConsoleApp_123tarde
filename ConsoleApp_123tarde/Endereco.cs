﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_123tarde
{
    public class Endereco
    {
        public int Id;
        public string Cep;
        public string Rua;
        public string Numero;
        public string Bairro;
        public string Cidade;

        public Endereco(int id, string cep, string rua, string numero, string bairro, string cidade)
        {
            Id = id;
            Cep = cep;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
        }
      
        public string EnderecoCompleto()
        {
            return "Rua" + Rua + ", N° " + Numero + " Bairro " + Bairro + "Cidade: " + Cidade;
        }

        public int getId()
        {
            return Id;
        }
        public string getCep()
        {
                return Cep;
        }
        public string getRua() 
        {
            return Rua;
        }
        public string getNumero()
        {
            return Numero;
        }
        public string getBairro()
        {
            return Bairro;
        }
        public string getCidade()
        {
            return Cidade;
        }

        public void setId(int id)
        {
            Id = id;
        }
        public void setCep(string cep)
        {
            Cep = cep;
        }
        public void setRua(string rua)
        {
            Rua = rua;
        }
        public void setNumero(string numero)
        {
            Numero = numero;
        }
        public void setBairro(string bairro)
        {
            Bairro = bairro;
        }
        public void setCidade(string cidade)
        {
            Cidade = cidade;
        }
        public void AtualizarEndereco(string rua, string numero, string bairro)
        {
            setBairro(bairro);
            setNumero(numero);
            setRua(rua);
        }
    }

}
