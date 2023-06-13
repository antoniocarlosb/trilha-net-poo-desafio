namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public override void InstalarAplicativo(string nomeApp)
        {      
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Iphone.");      
        }        
    }
}