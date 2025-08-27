namespace DesafioPOO.Models
{
    // Classe que herda de Smartphone
    public class Nokia : Smartphone
    {
        // Construtor que chama o construtor da classe base
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        //  método abstrato
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia...");
        }
    }
}
