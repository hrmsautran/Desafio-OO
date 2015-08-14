using System;
using ConsoleOO.Classes;
using ConsoleOO.Interfaces;

namespace ConsoleOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var urso = new Urso();
            var objAnimal = animal(urso);
        }

        public static string animal(IAnimal animal)
        {
            Console.WriteLine("{0}, \n\n{1}, \n\n{2}\n\n", animal.Andar(), animal.EmitirSom(), animal.Atacar());
            return "";
        }
    }
}
