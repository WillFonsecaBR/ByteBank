using System;
using System.Collections.Generic;
using System.Text;

namespace _05___ByteBank
{
    public class Cliente
    {
        public string nome;
        public string email;
        public int cpf;
        public string profissao;
        public Endereco endereco;
    }    
    public class Endereco
    {
        public int numero;
        public string rua;
        public string cidade;
        public string estado;
        public string pais;
    }
}
