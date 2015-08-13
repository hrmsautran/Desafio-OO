using System;
using ConsoleOO.Classes;

namespace ConsoleOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var cavalo = new Cavalo();
            var leao = new Leao();
            var urso = new Urso();

            Console.WriteLine("--- CAVALO ---");
            Console.WriteLine("O Cavalo: \nAnda: {0}, \nEmite o som: {1} e \nAtaca: {2}", cavalo.Andar(), cavalo.EmitirSom(), cavalo.Atacar());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("--- URSO ---");
            Console.WriteLine("O Urso \nAnda: {0}, \nEmite o som: {1} e \nAtaca: {2}", urso.Andar(), urso.EmitirSom(), urso.Atacar());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("--- Leão ---");
            Console.WriteLine("O Leão \nAnda: {0}, \nEmite o som: {1} e \nAtaca: {2}", leao.Andar(), leao.EmitirSom(), leao.Atacar());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
