namespace DUNGEON_DIO.src.entity
{
    public class Wizard : Hero
    {
     public Wizard(string name, int level, int hp, int mp){
         this.name = name;
         this.level = level;
         this.hp = hp;
         this.mp = mp;
     }
     public override  string Atack(){
         return "hello";
     }

    }
}