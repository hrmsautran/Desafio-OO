using ConsoleOO.Interfaces;

namespace ConsoleOO.Classes
{
    class Cavalo : IAnimal
    {
        public override string Andar()
        {
            return "O Cavalo anda com 4 Patas!";
        }

        public override string Atacar()
        {
            return "E ataca com coice!";
        }

        public override string EmitirSom()
        {
            return "Relincha!!";
        }
    }
}
