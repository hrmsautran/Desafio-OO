using System;
using ConsoleOO.Interfaces;

namespace ConsoleOO.Classes
{
    public class Urso : IAnimal
    {
        public override string Andar()
        {
            return "O Cavalo anda com 2 ou 4 Patas!";
        }

        public override string Atacar()
        {
            return "E ataca com mordidas e abraço de Urso!";
        }

        public override string EmitirSom()
        {
            return "Faz um som escroto!!";
        }
    }
}
