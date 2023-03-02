namespace controleClientes
{
    class PessoaFisica : Cliente
    {
        public string cpf { get; set; }
        public string rg { get; set; }

        /*public override string ToString()
        {
            return base.ToString() + "Nome: " + value.ToString();
        }*/

    }
}