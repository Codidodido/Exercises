using System;
using System.Text.RegularExpressions;

namespace Abilities
{
    public class AttackAbility: IAbility
    {
        public void UseAbility()
        {
            Console.WriteLine("Attack ... .");
        }
    }
}