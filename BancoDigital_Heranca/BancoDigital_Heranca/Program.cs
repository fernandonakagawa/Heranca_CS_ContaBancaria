using System;

namespace BancoDigital_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco b = new Banco("Banco Tio Patinhas");
            Agencia a1 = new Agencia("Agencia do Luizinho", 100);
            Agencia a2 = new Agencia("Agencia do Huguinho", 101);

            Cliente c1 = new Cliente("Pateta", "001");
            Cliente c2 = new Cliente("Pluto", "002");
            ClienteEspecial ce1 = new ClienteEspecial("Donald", "003");

            b.AdicionarAgencia(a1);
            b.AdicionarAgencia(a2);
            b.Clientes.Add(c1);
            b.Clientes.Add(c2);
            b.Clientes.Add(ce1);

            ContaCorrente ct1 = new ContaCorrente(100, 1000,
                "001", 100f, b.IsClienteEspecial("001"));
            ContaPoupanca cp1 = new ContaPoupanca(101, 1000,
                "002", 1000f, 0.01f);
            ContaCorrente ct2 = new ContaCorrente(100, 1000,
                "003", 100f, b.IsClienteEspecial("003"));


            a1.AdicionarConta(ct1);
            a2.AdicionarConta(cp1);


        }
    }
}
