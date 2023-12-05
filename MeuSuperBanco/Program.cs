namespace MeuSuperBanco
{
    public class Program
    {
        static void Main(string[] args)
        {
            
                ContaBanco contaB = new ContaBanco("Ricardo", 10000);
                Console.WriteLine($"A conta {contaB.Numero} de {contaB.Dono} foi criada com {contaB.Saldo}");
                Console.WriteLine();

            try
            {
                contaB.Sacar(100, DateTime.Now, "Fiz compras");
                contaB.Depositar(1500, DateTime.Now, "deposito");
                contaB.Sacar(0, DateTime.Now, "pagar o aluguel");
                contaB.Sacar(100, DateTime.Now, "Escola das crianças");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Operação nao realizada");
            }


            Console.WriteLine(contaB.PegarMovimentacao());
            Console.WriteLine($"Meu saldo Atual e: {contaB.Saldo}");

        }
    }
}
