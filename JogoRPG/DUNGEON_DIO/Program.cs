using System;

using DUNGEON_DIO.src.entity;

namespace DUNGEON_DIO
{
    public class Game
    {
        static void Main (){
            
            Hero batman = new Hero("Bruci", 100, 100, 0);
            ninja teste = new ninja("dhieison", 100, 100, 0);


            Console.WriteLine(batman);

            Console.WriteLine(batman.Atack());
            Console.WriteLine(teste.Atack(10));
        }
    }
}