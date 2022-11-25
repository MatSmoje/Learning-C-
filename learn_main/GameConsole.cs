using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_main
{
    internal class GameConsole
    {
        string command;
        string output = "";
        Character obj;

        /* COMMANDOS
         * exp
         * stat
         * checkmajetic
         * setcity
         * getek
         * rep+-
         * 
         * pf
         * setpf
         * bag
         * transform
         * createitem
         */

        public GameConsole(Character obj)
        {
            this.obj = obj;
        }

            public void Interface(string LastMsg)
        {
            
            Console.Clear();
            Console.WriteLine($"     {obj.name}    ");
            Console.WriteLine($"     {obj.city} - {obj.playerMode}    ");
            Console.WriteLine($"------------------------------  Level {obj.level}");
            Console.WriteLine($"|       ____                 |  Exp {obj.experience}");
            Console.WriteLine($"|      (     )               |  Next Exp {obj.experienceLimit}");
            Console.WriteLine($"|    __|o  o|__              |");
            Console.WriteLine($"|   |   |__|   |             |  Health {obj.health}");
            Console.WriteLine($"|  |            |            |  Mana {obj.mana}");
            Console.WriteLine($"| |              |           |  Stamina  {obj.stamina}");
            Console.WriteLine($"|  |              |          |");
            Console.WriteLine($"|   |            |           |  Max.Load  ");
            Console.WriteLine($"|    |          |            |  Ek.Count  {obj.enemyKill}");
            Console.WriteLine($"|     |        |             |");
            Console.WriteLine($"|      |      |              |  Level Up!: {obj.levelPool}");
            Console.WriteLine($"------------------------------");
            Console.WriteLine($"   Str. {obj.str}  Int. {obj.intelligence}  Vit. {obj.vit}");
            Console.WriteLine($"   Dex. {obj.dex}  Mag. {obj.magic}  Chr. {obj.charisma}");
            Console.WriteLine($"--------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{LastMsg}");
            Console.ResetColor();
        }

        public string GetCommand()
        {
            Console.Write($"$ ");
            command = Console.ReadLine();
            string[] commandSplited = command.Split(' ');
            string OutputCommand = "";

            if (commandSplited[0] == "/exp") OutputCommand = ExperienceCommand(commandSplited);
            else if (commandSplited[0] == "/stat") OutputCommand = StatCommand(commandSplited);
            else if (commandSplited[0] == "/checkmp") OutputCommand = CheckMajesticCommand(commandSplited);
            else if (commandSplited[0] == "/setcity") OutputCommand = SetCityCommand(commandSplited);
            else if (commandSplited[0] == "/getek") OutputCommand = GetEkCommand(commandSplited);
            else if (commandSplited[0] == "/help") OutputCommand = HelpCommand();

            else if (commandSplited[0] == "/rep+") Console.WriteLine("rep+");
            else if (commandSplited[0] == "/rep-") Console.WriteLine("rep-");
            else if (commandSplited[0] == "/checkrep") OutputCommand = CheckRepCommand(commandSplited);
            else OutputCommand = "Command Error";

            return OutputCommand; 
        }

        public string ExperienceCommand(string[] commandSplited)
        {
            string output = "";
            bool expBool = int.TryParse(commandSplited[1], out int amount);
            if (amount < 1) expBool = false; 
            if (expBool)
            {
                obj.GainExperience(amount);
                output = $"{amount} Experience assigned";
            }
            else output = $"Command Error";
            return output;
        }

        public string StatCommand(string[] commandSplited)
        {
            string output = "";
            string statType = commandSplited[1];
            bool BoolValueToAdd = int.TryParse(commandSplited[2], out int ValueToAdd);
            if (ValueToAdd <= 0) BoolValueToAdd = false;
            if (BoolValueToAdd) output = obj.AddStat(statType, ValueToAdd);
            else output = $"Command Error";

            return output;
        }
        /*asdasdasdasdadas*/
        public string CheckMajesticCommand(string[] commandSplited)
        {
            string output = "";
            if (commandSplited.Length > 1)
            {
                output = "Command Error";
            }
            else output = obj.CheckMajestic();
            
            return output;
        }
        public string SetCityCommand(string[] commandSplited)
        {
            string output = "";
            if (obj.city == "Traveller")
            {
                if ((commandSplited[1] == "Elvine") || (commandSplited[1] == "Aresden"))
                {
                    obj.city = commandSplited[1];
                    output = $"Congratulations!! You are now {obj.city}!";
                }
                else output = $"Command Error";
            }
            else
            {
                output = $"You are already {obj.city}";
            }

            return output;
        }

        public string GetEkCommand(string[] commandSplited)
        {
            string output = "";
            if ((obj.city == "Traveller") || (commandSplited.Length > 1)) 
            {
                output = $"Command Error or you are {obj.city}";
            }
            else
            {
                obj.GetEK();
                output = $"Enemy-Kill-Count has been increased by 1points.";
            }

            return output;
        }

        public string HelpCommand()
        {
            string output = "";
            output = "List of commands: \n" +
                "/exp [number] \n" +
                "/stat --arg [number] \n" +
                "/checkmp\n" +
                "/setcity [City]\n" +
                "/getek\n" +
                "/rep+ [Name]\n" +
                "/rep- [Name]\n" +
                "/checkrep";
            return output;
        }

        public string CheckRepCommand(string[] commandSplited)
        {
            string output;
            if (commandSplited.Length > 1)
            {
                output = "Command Error";
            }

            else output = $"You have {obj.ShowRep()}";
            return output;
        }

    }
}
/*
 "/checkmp") OutputCommand = CheckMajesticCommand(commandSplited);
            else if (commandSplited[0] == "/setcity") OutputCommand = SetCityCommand(commandSplited);
            else if (commandSplited[0] == "/getek") OutputCommand = GetEkCommand(commandSplited);
            else if (commandSplited[0] == "/help"
 
 */