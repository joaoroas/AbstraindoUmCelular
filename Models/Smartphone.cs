namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string modelo;
        protected string imei;
        protected int memoria;

        public Smartphone(string numero, string modeloAtual, string imeiAtual, int memoriaAtual)
        {
            Numero = numero;
            modelo = modeloAtual;
            imei = imeiAtual;
            memoria = memoriaAtual;

        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}