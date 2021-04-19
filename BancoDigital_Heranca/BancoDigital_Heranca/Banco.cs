using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDigital_Heranca
{
    class Banco
    {
        private string _nome;
        private List<Agencia> _agencias;
        private List<Cliente> _clientes;

        public string Nome { get => _nome; private set => _nome = value; }
        public List<Cliente> Clientes { get => _clientes; private set => _clientes = value; }
        public List<Agencia> Agencias { get => _agencias; private set => _agencias = value; }

        public Banco(string nome)
        {
            Nome = nome;
            Clientes = new List<Cliente>();
            Agencias = new List<Agencia>();
        }

        public bool AdicionarAgencia(Agencia a)
        {
            foreach(Agencia x in this.Agencias)
            {
                if (x.Numero == a.Numero) return false;
            }
            this.Agencias.Add(a);
            return true;
        }
        public bool RemoverAgencia(Agencia a)
        {
            return this.Agencias.Remove(a);
        }
        public bool IsCliente(Cliente c)
        {
            return this.Clientes.Contains(c);
        }
        public bool IsClienteEspecial(string cpf)
        {
            foreach(Cliente c in this.Clientes)
            {
                if (c.Cpf.Equals(cpf))
                {
                    if (c is ClienteEspecial) return true;
                    return false;
                }
            }
            throw new Exception("Cliente não encontrado");
        }
    }

}
