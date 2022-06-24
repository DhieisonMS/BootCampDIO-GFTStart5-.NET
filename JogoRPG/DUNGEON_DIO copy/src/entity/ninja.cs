namespace DUNGEON_DIO.src.entity
{
    public class ninja : Hero
    {   
        public ninja(string name, int level, int hp, int mp){
            this.name = name;
            this.level = level;
            this.hp = hp;
            this.mp = mp;
        }

        public override string Atack(int level){
            if(level == 0){
                return "teste";
            }else{
                return "raduk";
            }
            }
        
    }
}