using System;
using ConsoleOO.Interfaces;

namespace ConsoleOO.Classes
{
    public class Urso : IAnimal
    {
        public string Andar()
        {
            return "Anda com 2 e 4 patas!!";
        }

        public string Atacar()
        {
            return "Ataca com MORDIDA e GARRAS!!";
        }

        public string EmitirSom()
        {
            return "Rosna? Urra? Sei lá... mas dá medo!! =D";
        }
    }
}
