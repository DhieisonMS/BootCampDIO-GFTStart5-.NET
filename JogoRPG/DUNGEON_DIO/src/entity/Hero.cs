namespace DUNGEON_DIO.src.entity
{
    public class Hero
    {
        public string name;
        public int level;
        public int hp;
        public int mp;

        public Hero(string name, int level, int hp, int mp){
            this.name = name;
            this.level = level;
            this.hp = hp;
            this.mp = mp;
        }

        public Hero(){}

        public override string ToString (){
            
            return $"{name} {level} {hp} {mp}";
           
        }
        public virtual string Atack(){
            return "hi";
        }

        public virtual string Atack(int level){
            return "show";
        }


    }
}