using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBasedCombatStateMachine : MonoBehaviour {

    private bool hasAddedEXP = false;
    private BattleStateStart battleStateStartScript = new BattleStateStart();
    private BattleCalculations battleCalcScript = new BattleCalculations();
    private BattleStateEnemyChoice battleStateEnemyChoiceScript = new BattleStateEnemyChoice();

    public static BaseAbilities playerUsedAbility;
    public static BaseAbilities enemyUsedAbility;

    public static int totalTurnCount;
    public static bool playerDidCompleteTurn;
    public static bool enemyDidCompleteTurn;
    public static BattleStates currentUser; // enemy or player choice 

    // List of Battle States
    public enum BattleStates
    {
        START,
        PLAYERCHOICE,
        ENEMYCHOICE,
        CALCULATEDAMAGE,
        ENDTURN,
        LOSE,
        WIN
    }

    public static BattleStates currentState;

	void Start () {

        hasAddedEXP = false;
        totalTurnCount = 1;
        // On load the current state with be BattleState - Start
        currentState = BattleStates.START;
	}
	
	void Update () {

        // Shows current state in debug log
        Debug.Log(currentState);

        switch (currentState)
        {
            case (BattleStates.START):
                // Setup battle function
                // Create enemy
                battleStateStartScript.PrepareBattle();
                // Choose who attacks first
                    // BattleStates.PLAYERCHOICE
                break;

            case (BattleStates.PLAYERCHOICE):   // Player chooses ability to use
                currentUser = BattleStates.PLAYERCHOICE;
                break;

            case (BattleStates.ENEMYCHOICE):    // Enemy chooses which attack to perform
                // enemy AI goes here
                currentUser = BattleStates.ENEMYCHOICE;
                battleStateEnemyChoiceScript.EnemyCompleteTurn();
                //enemyDidCompleteTurn = true;
                //CheckWhoGoesNext();
                break;
            
            case (BattleStates.CALCULATEDAMAGE):    // Calculate damage done by player
                if(currentUser == BattleStates.PLAYERCHOICE)
                {
                    battleCalcScript.CalculateUsedPlayerAbility(playerUsedAbility);
                }

                if (currentUser == BattleStates.ENEMYCHOICE)
                {
                    battleCalcScript.CalculateUsedEnemyAbility(enemyUsedAbility);
                }

                Debug.Log("CALCULATING DAMAGE");
                CheckWhoGoesNext();
                break;

            case (BattleStates.ENDTURN):
                totalTurnCount += 1;
                playerDidCompleteTurn = false;
                enemyDidCompleteTurn = false;
                //Debug.Log(totalTurnCount);
                break;

            case (BattleStates.LOSE):
                
                break;

            case (BattleStates.WIN):    // Post battle - reward player exp, gold, items

                if (!hasAddedEXP)
                {
                    IncreaseExperience.AddExperience();
                    hasAddedEXP = true;
                }
       
                break;
        }
	}

    // Test GUI 
    void OnGUI()
    {
        // Button that cycles through BattleStates
        if(GUILayout.Button("NEXT STATE"))
        {
            if (currentState == BattleStates.START)
                currentState = BattleStates.PLAYERCHOICE;
        }
    }

    private void CheckWhoGoesNext()
    {
        if(playerDidCompleteTurn && !enemyDidCompleteTurn)
        {
            // enemy turn
            currentState = BattleStates.ENEMYCHOICE;
        }

        if(!playerDidCompleteTurn && enemyDidCompleteTurn)
        {
            // player turn
            currentState = BattleStates.PLAYERCHOICE;
        }

        if (playerDidCompleteTurn && enemyDidCompleteTurn)
        {
            // end turn state
            currentState = BattleStates.ENDTURN;
        }
    }
}
