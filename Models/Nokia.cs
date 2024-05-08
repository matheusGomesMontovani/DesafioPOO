namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public string Nome {  get; set; }
        public Nokia(string nome, string numero, string modelo, string imei, int memoria)
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