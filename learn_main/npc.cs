using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_main
{
    internal class NPC
    {
        public string name;
        public int id;

        public int friendlyType; /*0: Neutral, 1. AresEnemy 2. ElvineEnemy 3. AllEnemy */
        public int buff;
        /*
         * 0. None
         * 1. Poisonous
         * 2. Berserk
         * 3. Anti-Magic
         * 4. Anti-Physical
         * 5. Clairvoyant
         */
        public int health;
        public int mana;

        public int exp;
        public int damage;

       
        public List<int> dropItems;
        
        public NPC(string name)
        {
            this.name = name;
        }

        public void Attack()
        {
            Console.WriteLine("Atacando");
        }
        public void RecoverMana()
        {
            Console.WriteLine("Recobrar Mana o algo");
        }
        public void Dropear()
        {
            Console.WriteLine("Dropeando Item");
        }
        public void SendExp()
        {
            Console.WriteLine("Mandando mensaje de EXP");
        }
        public void Die()
        {
            Console.WriteLine("He muerto");
        }

    }
}
