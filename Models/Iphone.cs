namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public string Nome { get; set; }
        public Iphone(string nome, string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
        {
            Nome = nome;
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine(nomeApp);
        }
    }
}