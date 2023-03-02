namespace controleClientes
{
    class PessoaJuridica : Cliente
    {
        public string cnpj {get; set;}
        public string ie {get; set;}

    //está sendo reescrito, o que indica a reescrita é o override
        public override void PagarImposto(float v)
        {
            this.valor = v;
            this.valorImposto = this.valor*20/100;
            this.total = this.valor + this.valorImposto;
        }

    }

}