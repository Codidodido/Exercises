using System;

namespace Abilities
{
    public class HealAbility: IAbility
    {
        public void UseAbility()
        {
            Console.WriteLine("Heal ... .");
        }
    }
}