using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testando Iphone");
        Smartphone iphone = new Iphone("11999999999", "iPhone 13", "IMEI123456789", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        Console.WriteLine("Testando Nokia");
        Smartphone nokia = new Nokia("11988888888", "Nokia Tijolão", "IMEI987654321", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Telegram");
    }
}
