using System;
namespace controleClientes
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean contador = false;
            Console.WriteLine("Informe o nome do Cliente:");
            string nomeCliente = Console.ReadLine();

            Console.WriteLine("Informe o endereço do Cliente:");
            string enderecoCliente = Console.ReadLine();

            Console.WriteLine("Digite (f) para Pessoa física ou (j) para Pessoa Jurídica");
            string tipoCliente = Console.ReadLine();

            while (contador == false)
            {

                if (string.Equals(tipoCliente, "f", StringComparison.InvariantCultureIgnoreCase))
                {
                    PessoaFisica pf = new PessoaFisica();
                    pf.nome = nomeCliente;
                    pf.endereco = enderecoCliente;
                    Console.WriteLine("Informe seu CPF: ");
                    pf.cpf = Console.ReadLine();
                    Console.WriteLine("Informe seu RG: ");
                    pf.rg = Console.ReadLine();
                    Console.WriteLine("Informe o valor da compra: ");
                    float valPag = float.Parse(Console.ReadLine());
                    pf.PagarImposto(valPag);
                    Console.WriteLine(pf.ToString());
                    Console.WriteLine("--------Pessoa Física--------");
                    Console.WriteLine("Nome: " + pf.nome);
                    Console.WriteLine("Endereço: " + pf.endereco);
                    Console.WriteLine("CPF: " + pf.cpf);
                    Console.WriteLine("RG:" + pf.rg);
                    Console.WriteLine("Valor da Compra: " + pf.valor.ToString("C"));
                    Console.WriteLine("Imposto: " + pf.valorImposto.ToString("C"));
                    Console.WriteLine("Total à Pagar: " + pf.total.ToString("C"));
                    contador = true;
                }
                else if (string.Equals(tipoCliente, "j", StringComparison.InvariantCultureIgnoreCase))
                {
                    PessoaJuridica pj = new PessoaJuridica();
                    pj.nome = nomeCliente;
                    pj.endereco = enderecoCliente;
                    Console.WriteLine("Informe seu CNPJ: ");
                    pj.cnpj = Console.ReadLine();
                    Console.WriteLine("Informe seu valor do IE: ");
                    pj.ie = Console.ReadLine();
                    Console.WriteLine("Informe o valor da compra: ");
                    float valPag = float.Parse(Console.ReadLine());
                    pj.PagarImposto(valPag);
                    Console.WriteLine(pj.ToString());
                    Console.WriteLine("--------Pessoa Jurídica--------");
                    Console.WriteLine("Nome: " + pj.nome);
                    Console.WriteLine("Endereço: " + pj.endereco);
                    Console.WriteLine("CNPJ: " + pj.cnpj);
                    Console.WriteLine("IE: " + pj.ie);
                    Console.WriteLine("Valor da Compra: " + pj.valor.ToString("C"));
                    Console.WriteLine("Imposto: " + pj.valorImposto.ToString("C"));
                    Console.WriteLine("Total à Pagar: " + pj.total.ToString("C"));
                    contador = true;
                }
                else
                {
                    Console.WriteLine("\n\nErro, por favor informar uma informação válida");
                    Console.WriteLine("Digite (f) para Pessoa física ou (j) para Pessoa Jurídica");
                    tipoCliente = Console.ReadLine();
                    contador = false;
                }

            }

        }
    }
}

