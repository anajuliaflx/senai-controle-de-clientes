namespace controleClientes
{
    class Cliente
    {
        public string nome{get; set;}
        public string endereco{get; set;}
        public float valor{get; protected set;}
        public float valorImposto{get; protected set;}
        public float total{get; protected set;}

    //é utilizado o virtual para que ele permita a reescrita do método;
        public virtual void PagarImposto(float v)
        {
            this.valor = v;
            this.valorImposto = this.valor*10/100;
            this.total = this.valor + this.valorImposto;
        }

    }
}