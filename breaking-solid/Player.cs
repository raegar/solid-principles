using System;

namespace breaking_solid
{
    public class Player
    {
        private readonly PlayerClass playerClass;
        private readonly string playerName;

        public int Armour { get; set; }
        public int Health { get; set; }

        public Player(PlayerClass playerClass, string playerName)
        {
            this.playerClass = playerClass;
            this.playerName = playerName;
        }

        public string GetNameAndClass()
        {
            switch(playerClass)
            {
                case PlayerClass.Fighter:
                    return $"{playerName} is a tough Fighter";
            
                case PlayerClass.Wizard:
                    return $"{playerName} is a magical Wizard";

                case PlayerClass.Rogue:
                    return $"{playerName} is a sneaky Rogue";

                default: return $"{playerName} is not a recgnosed class";
            } //This violates the Open Closed Principle as we need to add extra cases if we create a new Playerclass type in the future such as Bard

        }

    }
}