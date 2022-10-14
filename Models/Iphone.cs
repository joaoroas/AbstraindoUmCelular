namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modeloAtual, string imeiAtual, int memoriaAtual) : base(numero, modeloAtual, imeiAtual, memoriaAtual)
        {
            Numero = numero;
            modelo = modeloAtual;
            imei = imeiAtual;
            memoria = memoriaAtual;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no {modelo}");
        }
    }
}