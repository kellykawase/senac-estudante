namespace Bancario
{
    public class Conta
    {
        private int numero;
        private int digitoVerificador;
        private double saldo;
        private string titular;
        public double Saldo
        {
            get
            {
                return saldo;
            }
        }
        public int Numero
        {
            get
            {
                return numero;
            }
            set
          {
               numero = value;
            }
        }

                public string Titular
        {
            get
            {
                return titular;
            }
            set
          {
               titular = value;
            }
        }

        public int DigitoVerificador
        {
            get
            {
                return digitoVerificador;
            }
            set
          {
               digitoVerificador = value;
            }
        }
        public bool RelizarSaque(double valor)
        {
            if(saldo > valor)
            {
                saldo = saldo - valor;
                 return true;
            }
            else
            {
                return false; //saldo insuficiente
            }
        }
        public void RealizarDeposito(double valor)
        {
            if(valor > 0)
            {
                saldo = saldo + valor;
            }
        }
    }
}