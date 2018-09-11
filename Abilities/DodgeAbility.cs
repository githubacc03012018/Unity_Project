namespace Assets.Scripts.Ability
{
    public class DodgeAbility : Ability
    {
        public override void Upgrade()
        {
            this.Cooldown -= 0.5f;
        }
    }
}
