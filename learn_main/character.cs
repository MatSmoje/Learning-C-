using System;

namespace learn_main
{
    internal class Character
    {
        //private string name; carezco de get / set
        //private string name { get; set; }
        private int maxStats = 200;
        private int maxLevel = 180;

        public string name;

        public int level = 1;
        public int majesticPoint = 0;
        public int levelPool = 10;

        public int experience = 0;
        public int experienceLimit = 100;

        public int str = 10;
        public int dex = 10;
        public int intelligence = 10;
        public int magic = 10;
        public int vit = 10;
        public int charisma = 10;

        public int stamina = 22;
        public int mana = 27;
        public int health = 37;

        public int rep = 0;
        public int enemyKill = 0;
        public int contribution = 0;

        public string city = "Traveller";
        public string playerMode = "GM";

        public int criticals;

        // Constructor 
        public Character(string name)
        {
            this.name = name;
            this.criticals = level / 10;
        }
        public void CalculateHP_MP_SP()
        {
            health = vit * 3 + level * 2 + str/2; //(level-1) * 2 + 37 + 3 * (vit-10);
            mana = magic * 2 + level * 2 + intelligence / 2;
            stamina = str * 2 + level * 2;
            criticals = level / 10;
            //https://www.hblmdl.com/charsimu.html
        }
        public void LevelUp()
        {
            if (level < maxLevel)
            {
                level++;
                levelPool += 3;
            }
            else majesticPoint++;
            CalculateHP_MP_SP();
        }
        public int SetExperienceLimit()
        {
            if (level <= 15) experienceLimit = (level + 1) * 50;
            else if (level == 16) experienceLimit = 1139;
            else if (level > 16 && level <= 32) experienceLimit = experienceLimit + 83 + 2 * (level - 16);
            else if (level == 33) experienceLimit = 6324;
            else if (level > 33 && level <= 49) experienceLimit = experienceLimit + 318 + 8 * (level - 33);
            else if (level == 50) experienceLimit = 25959;
            else if (level > 50 && level <= 66) experienceLimit = experienceLimit + 959 + 18 * (level - 50);
            else if (level == 67) experienceLimit = 77384;
            else if (level > 67 && level <= 83) experienceLimit = experienceLimit + 2210 + 32 * (level - 67);
            else if (level == 84) experienceLimit = 184875;
            else if (level > 84 && level <= 100) experienceLimit = experienceLimit + 4275 + 50 * (level - 84);
            else if (level == 101) experienceLimit = 379644;
            else if (level > 101 && level <= 117) experienceLimit = experienceLimit + 7358 + 72 * (level - 101);
            else if (level == 118) experienceLimit = 699839;
            else if (level > 118 && level <= 134) experienceLimit = experienceLimit + 11663 + 98 * (level - 118);
            else if (level == 135) experienceLimit = 1190544;
            else if (level > 135 && level <= 151) experienceLimit = experienceLimit + 17394 + 128 * (level - 135);
            else if (level == 152) experienceLimit = 1903779;
            else if (level > 152 && level <= 168) experienceLimit = experienceLimit + 24755 + 162 * (level - 152);
            else if (level == 169) experienceLimit = 2898500;
            else if (level > 169 && level < 180) experienceLimit = experienceLimit + 33950 + 200 * (level - 169);
            else if (level == 180) experienceLimit = experienceLimit + 99950 + 200 * 20;
            return experienceLimit;
        }
        public void GainExperience(int amount)
        {
            if (((level < 19) && (city == "Traveller")) || (city != "Traveller"))
                experience = experience + amount;

            if (experience > experienceLimit)
            {
                while (true)
                {
                    if (((level < 19) && (city == "Traveller")) || ( city != "Traveller"))
                    {
                        experience -= experienceLimit;
                        LevelUp();
                        experienceLimit = SetExperienceLimit();
                        if ((experience - experienceLimit) < 0) break;
                    }
                    else break;
                    
                }
            }
            else if (experience == experienceLimit)
            {
                if (((level < 19) && (city == "Traveller")) || (city != "Traveller"))
                {
                    LevelUp();
                    experience = 0;
                    experienceLimit = SetExperienceLimit();
                }
            }
 
            
        }
        public string AddStat(string statType, int ValueToAdd)
        {
            string output = "Stats added correctly";
            bool exitWhile = true; 

            if (levelPool <= 0) output = "Not enough LevelPool";
            if (ValueToAdd <= 0) output = "Command Error";


            while ((ValueToAdd > 0) && (levelPool > 0) && (exitWhile))
            {
                switch (statType)
                {
                    case "-str":
                        if (str < maxStats)
                        {
                            str++;
                            levelPool--;
                            ValueToAdd--;
                        }
                        else exitWhile = false;
                        break;
                    case "-dex":
                        if (dex < maxStats)
                        {
                            dex++;
                            levelPool--;
                            ValueToAdd--;
                        }
                        else exitWhile = false;
                        break;
                    case "-int":
                        if (intelligence < maxStats)
                        {
                            intelligence++;
                            levelPool--;
                            ValueToAdd--;
                        }
                        else exitWhile = false;
                        break;
                    case "-mag":
                        if (magic < maxStats)
                        {
                            magic++;
                            levelPool--;
                            ValueToAdd--;
                        }
                        else exitWhile = false;
                        break;
                    case "-vit":
                        if (vit < maxStats)
                        {
                            vit++;
                            levelPool--;
                            ValueToAdd--;
                        }
                        else exitWhile = false;
                        break;
                    case "-chr":
                        if (charisma < maxStats)
                        {
                            charisma++;
                            levelPool--;
                            ValueToAdd--;
                        }
                        else exitWhile = false;
                        break;
                }
            }
            CalculateHP_MP_SP();
            return output;

        }
        public string CheckMajestic()
        {
            string output = $"Majestic Points: {majesticPoint}"; 
            return output;
        }

        public void GetEK()
        {
            enemyKill++;
        }
        public string ShowRep()
        {
            return rep.ToString();
        }
    }
}
/*
 * Console.WriteLine($"|  Level: {level} \t|  Dex. {dex}  Mag. {magic}  Chr. {charisma}                           |");
            Console.WriteLine($"|  Exp: {experience}/{experienceLimit} \t|                     |");
            Console.WriteLine($"|  Level Up!: {levelPool} \t|                             |");
 */
