[System.Serializable]

public class AttackAbility : BaseAbilities {

	public AttackAbility()
    {
        AbilityName = "Normal Attack";
        AbilityDescription = "A normal attack";
        AbilityID = 1;
        AbilityPower = 10;
        AbilityCost = 5;
    }
}
