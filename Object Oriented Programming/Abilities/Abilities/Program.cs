using static Abilities.Abilities;

namespace Abilities
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Character<AttackAbility> warrior = new Character<AttackAbility>(Abilities.AttackAbility);
            Character<MagicAbility> magician = new Character<MagicAbility>(Abilities.MagicAbility);
            Character<HealAbility> healer = new Character<HealAbility>(Abilities.HealAbility);
            
            warrior.UseAbility();
            magician.UseAbility();
            healer.UseAbility();
        }
    }
}