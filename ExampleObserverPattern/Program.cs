using System;

namespace ExampleObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EstacaoMeteorologica estacaoMeteorologica = new EstacaoMeteorologica();
            NovasAgenciasNoticias agenciasNoticias1 = new NovasAgenciasNoticias("Agencia de Noticia de São Paulo");
            estacaoMeteorologica.Anexar(agenciasNoticias1);

            NovasAgenciasNoticias agenciasNoticias2 = new NovasAgenciasNoticias("Agencia de Noticia de Suzano");
            estacaoMeteorologica.Anexar(agenciasNoticias2);

            estacaoMeteorologica.Temperatura = 31.4f;
            estacaoMeteorologica.Temperatura = 25f;
            estacaoMeteorologica.Temperatura = 26.7f;
            estacaoMeteorologica.Temperatura = 34.7f;
            estacaoMeteorologica.Temperatura = 22.7f;
            estacaoMeteorologica.Temperatura = 15.7f;

            Console.ReadLine();
        }
    }
}
