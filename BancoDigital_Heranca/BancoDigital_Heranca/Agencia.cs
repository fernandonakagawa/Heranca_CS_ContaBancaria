using System.Collections.Generic;

namespace BancoDigital_Heranca
{
    class Agencia
    {
        private string _nome;
        private int _numero;
        private List<Conta> _contas;

        public string Nome { get => _nome; private set => _nome = value; }
        public int Numero { get => _numero; 
            private set 
            {
                if (value > 0) _numero = value;
                else throw new System.Exception("O número da agência deve ser maior que 0!");
            } 
        }
        public List<Conta> Contas { get => _contas; private set => _contas = value; }

        public Agencia(string nome, int numero)
        {
            Nome = nome;
            Numero = numero;
            this.Contas = new List<Conta>();
        }
        public bool AdicionarConta(Conta c)
        {
            if (c.NumeroAgencia != this.Numero) return false;
            foreach(Conta x in this.Contas)
            {
                if (x.NumeroConta == c.NumeroConta) return false;
            }
            this.Contas.Add(c);
            return true;
        }
        public bool RemoverConta(Conta c)
        {
            return this.Contas.Remove(c);
        }
    }
}