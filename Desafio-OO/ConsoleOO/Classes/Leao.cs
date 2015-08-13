using System;
using ConsoleOO.Interfaces;

namespace ConsoleOO.Classes
{
    class Leao : IAnimal
    {
        public string Andar()
        {
            return "Anda com 4 patas!!";
        }

        public string Atacar()
        {
            return "Ataque rápido com MORDIDA e GARRAS!!";
        }

        public string EmitirSom()
        {
            return "Rugeee e dá muito, mas muitoooo medo!! =[";
        }
    }
}
