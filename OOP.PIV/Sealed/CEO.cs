using OOP.PIV.Interfaces;

namespace OOP.PIV.Sealed
{
    //sealed class CEO : IPlayer, Manager // multilevel inheritance   // order is important
    sealed class CEO : Manager, IPlayer // multilevel inheritance 
    {
        public void Play()
        {
            Console.WriteLine("I love playing Golf :)");
        }
    }
}
