namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo;
        private string IMEI;
        private int Memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void DatelhesSmartphone(){
            Console.WriteLine($"Detalhes do {Modelo}:"
                    +$"\n\tNumero: {Numero}"
                    +$"\n\tMemoria: {Memoria}"
                    +$"\n\tIMEI: {IMEI}");
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando {Modelo}...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação no {Modelo}...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}