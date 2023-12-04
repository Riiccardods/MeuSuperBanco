namespace MeuSuperBanco
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaBanco contaB = new ContaBanco("Ricardo", 10000);
            Console.WriteLine($"A conta {contaB.Numero} de {contaB.Dono} foi criada com {contaB.Saldo}");


            contaB.Sacar(800, DateTime.Now, "Fiz compras");
            Console.WriteLine($"A conta esta com {contaB.Saldo}");

            contaB.Sacar(10000, DateTime.Now, "Recebi um pagamento");
            Console.WriteLine($"A conta esta com {contaB.Saldo}");
        }
    }
}
