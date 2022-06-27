using System;

using DUNGEON_DIO.src.entity;

namespace DUNGEON_DIO
{
    public class Game
    {
        static void Main (){
            
            Hero batman = new Hero("Bruci", 300, 100, 0);
            ninja teste = new ninja("dhieison", 100, 100, 0);
            Wizard ellen = new Wizard("ellen",1100, 1000, 1000);

            Console.WriteLine(batman);

            Console.WriteLine(batman.Atack());
            Console.WriteLine(teste.Atack(10));
            Console.WriteLine(ellen.Atack(110));
        }
    }
}