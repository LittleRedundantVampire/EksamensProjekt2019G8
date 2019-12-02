using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppe8Eksamensprojekt2019
{
    enum Ability { Sunblock, Fire, Ice };

    abstract class Character
    {
        protected int health;
        protected int damage;
        protected string name;


        public virtual void UpdateHealth(int health, int amount)
        {

        }

        public virtual void Attack()
        {

        }

        public virtual void UseAbility(Ability ability)
        {

        }

        public virtual void Speak()
        {

        }
    }
}
