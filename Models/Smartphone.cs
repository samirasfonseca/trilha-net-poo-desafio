namespace DesafioPOO.Models
{
    // Classe abstrata que serve como base para os smartphones
    public abstract class Smartphone
    {
        // Propriedades do smartphone
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        // Construtor que inicializa as propriedades
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Métodos comuns a todos os smartphones
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato que deve ser implementado nas classes filhas
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
