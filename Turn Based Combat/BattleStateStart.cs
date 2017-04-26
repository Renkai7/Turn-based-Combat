using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateStart {

    private BaseHeroClass newEnemy = new BaseHeroClass();

    private string[] enemyNames = new string[] { "Deadly Enemy", "Fierce Enemy", "Timid Enemy", "Powerful Enemy"};
    private int playerHealth;

    public void PrepareBattle()
    {
        // create enemy
        CreateNewEnemy();

        // display player/enemy health
        DeterminePlayerVitals();
        // choose who attacks first based on -specified stat- --may remove later
        TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.PLAYERCHOICE;
    }

    // Method sets up the enemies upon starting battle
    private void CreateNewEnemy()
    {
        newEnemy.CharacterName = enemyNames[Random.Range(0, enemyNames.Length)];
        newEnemy.CharacterLevel = Random.Range(GameInformation.PlayerLevel - 2, GameInformation.PlayerLevel + 2);
    }

    private void DeterminePlayerVitals()
    {
        GameInformation.PlayerName = "Test Name";
        playerHealth = 100;
        GameInformation.PlayerHealth = playerHealth;
    }
}
