using System;
using ConsoleOO.Interfaces;

namespace ConsoleOO.Classes
{
    class Leao : IAnimal
    {
        public override string Andar()
        {
            return "O Leão anda com 4 Patas!";
        }

        public override string Atacar()
        {
            return "E ataca com garras e mordidas!";
        }

        public override string EmitirSom()
        {
            return "Ruge!!";
        }
    }
}
