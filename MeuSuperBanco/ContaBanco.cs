using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MeuSuperBanco
{
    public class ContaBanco
    {
        public string Numero {  get; }
        public string Dono { get; set; }
        public decimal Saldo 
        {
            get
            {
                decimal saldo = 0;
                foreach (var item in todasTransacoes) 
                {
                    saldo += item.Valor;
                }
                return saldo;
            } 
        }

        public static int numeroConta = 123456;

        private List<Transacao> todasTransacoes = new List<Transacao>();

        public ContaBanco(string nome, decimal valor)
        {
            this.Dono = nome;
            numeroConta++;

            this.Numero = numeroConta.ToString();
            Depositar(valor, DateTime.Now, "Saldo Inicial");
        }

        public void Depositar(decimal valor, DateTime data, string obs) 
        {
            if (valor <= 0) 
            { 
                throw new ArgumentOutOfRangeException(nameof(valor),"Nao aceitamos deposito de valor menor ou = Zero");
            }

            Transacao trans = new Transacao(valor, data, obs);
            todasTransacoes.Add(trans);
        }
        public void Sacar(decimal valor, DateTime data, string obs) 
        {
            if (valor <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(valor), "Nao aceitamos de valor Zero");
            }
            if(Saldo - valor < 0) 
            {
                throw new InvalidOperationException("Essa operação nao e permitida");
            }

            Transacao trans = new Transacao(-valor, data, obs);
            todasTransacoes.Add(trans);
        }

    }
}
