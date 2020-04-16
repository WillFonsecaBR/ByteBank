public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    public void depositar(double valor)
    {
        this.saldo += valor;
    }

}



