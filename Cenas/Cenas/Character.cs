using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cenas
{
    class Character
    {
        /*Character Properties*/
        private int Health { get; set; }
        private string Name { get; set; }
        private int Strength { get; set; }
        private int Perception { get; set; }
        private int Endurance { get; set; }
        private int Charisma { get; set; }
        private int Intelligence { get; set; }
        private int Agility { get; set; }
        private int Luck { get; set; }


        public Character()
        {

        }

        public Character(int health, string name, int strength, int perception, int endurance, int charisma, int intelligence, int agility, int luck)
        {
            Health = health;
            Name = name;
            Strength = strength;
            Perception = perception;
            Endurance = endurance;
            Charisma = charisma;
            Intelligence = intelligence;
            Agility = agility;
            Luck = luck;
        }
    }
}
