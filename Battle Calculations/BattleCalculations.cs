using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCalculations  {

    // TODO: Increase damage of some move due to status inflicted on enemy
    // example: if enemy is afflicted with covered in water, lightning attack deal more damage

    private int abilityPower;
    private float totalAbilityPowerDamage;
    private int totalUsedAbilityDamage;

    // Damage done is shown here
    public void CalculateUsedPlayerAbility(BaseAbilities usedAbility)
    {
        Debug.Log("Used ability: " + usedAbility.AbilityName);

        // Formula for doing damage
        // ability damage + critical strike - armor + stat modifier * weapon damage + status effect
        totalUsedAbilityDamage = (int)CalculateAbilityDamage(usedAbility);
        Debug.Log(totalUsedAbilityDamage);
        TurnBasedCombatStateMachine.playerDidCompleteTurn = true;
        //TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.ENEMYCHOICE;
        // use ability
        // calculate damage
        // check status effect
            // if move has status effect
                // try to add effect
        // calculate total damage with status effect in mind
    }

    public void CalculateUsedEnemyAbility(BaseAbilities usedAbility)
    {
        Debug.Log("Used ability: " + usedAbility.AbilityName);

        // Formula for doing damage
        // ability damage + critical strike - armor + stat modifier * weapon damage + status effect
        totalUsedAbilityDamage = (int)CalculateAbilityDamage(usedAbility);
        Debug.Log(totalUsedAbilityDamage);
        TurnBasedCombatStateMachine.enemyDidCompleteTurn = true;
        //TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.ENEMYCHOICE;
        // use ability
        // calculate damage
        // check status effect
        // if move has status effect
        // try to add effect
        // calculate total damage with status effect in mind
    }

    // Formula for amount of damage done by ability goes here
    private float CalculateAbilityDamage(BaseAbilities usedAbility)
    {
        abilityPower = usedAbility.AbilityPower;    // gets power of the move
        totalAbilityPowerDamage = abilityPower;
        return totalAbilityPowerDamage;
    }
}
