using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAbilityChoice  {

    private int totalPlayerHealth;
    private int playerHealthPercentage;
    private BaseAbilities chosenAbility;

    public BaseAbilities ChooseEnemyAbility()
    {
        totalPlayerHealth = GameInformation.PlayerHealth;
        playerHealthPercentage = (int)((totalPlayerHealth / 100) * 100);

        if(playerHealthPercentage >= 75)
        {
            return chosenAbility = ChooseAbilityAtSeventyFivePercent();
        }
        else if (playerHealthPercentage < 75 && playerHealthPercentage >= 50)
        {
            return chosenAbility = new SwordSlash();
        }
        else if (playerHealthPercentage < 25)
        {
            return chosenAbility = new SwordSlash();
        }

        return chosenAbility = new AttackAbility();
    }

    private BaseAbilities ChooseAbilityAtSeventyFivePercent()
    {
        return chosenAbility = new SwordSlash();
    }
}
