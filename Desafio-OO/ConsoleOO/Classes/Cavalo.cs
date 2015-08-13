using ConsoleOO.Interfaces;

namespace ConsoleOO.Classes
{
    class Cavalo : IAnimal
    {
        public string Andar()
        {
            return "Anda com 4 patas!!";
        }

        public string Atacar()
        {
            return "Ataca com coice, mas, e raro isso acontecer!!";
        }

        public string EmitirSom()
        {
            return "Relincha!! \\ o /";
        }
    }
}
