namespace Abilities
{
    public class Character<T> where T: IAbility
    {
        private T _ability;
        
        public Character(T ability)
        {
            _ability = ability;
        }

        public void UseAbility()
        {
            _ability.UseAbility();
        }
    }
}