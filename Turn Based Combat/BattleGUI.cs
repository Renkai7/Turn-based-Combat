using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleGUI : MonoBehaviour {

    private Text playerName;
    private Text playerHealth;
    private Image playerHealthImage;

    //private string playerName;
    private int playerLevel;
    //private int playerHealth;
    private int playerSP;

	// Use this for initialization
	void Start () {

        playerName = transform.FindChild("PlayerInfoContainer").FindChild("PlayerPortrait").FindChild("PlayerName").GetComponent<Text>();
        playerName.text = GameInformation.PlayerName;
        playerHealth = transform.FindChild("PlayerInfoContainer").FindChild("PlayerHealthBar").FindChild("PlayerHealthValue").GetComponent<Text>();
        playerHealthImage = transform.FindChild("PlayerInfoContainer").FindChild("PlayerHealthBar").GetComponent<Image>();

        //playerName = GameInformation.PlayerName;
        playerLevel = GameInformation.PlayerLevel;
        //playerHealth = GameInformation.PlayerHealth;
        
	}
	
	// Update is called once per frame
	void Update () {
        playerName.text = GameInformation.PlayerName;
        playerHealth.text = GameInformation.PlayerHealth.ToString();
        // This controls the health bar fill amount based on how much health is left
        //playerHealthImage.fillAmount = GameInformation.PlayerHealth / 1;
    }

    void OnGUI()
    {

        // TODO: Only list moves available to player to limit number of abilities shown
       

        if(TurnBasedCombatStateMachine.currentState == TurnBasedCombatStateMachine.BattleStates.PLAYERCHOICE)
        {
            DisplayPlayersChoice();
        }
        

        // Need to show enemy health and enemy info
        // Need to show player information

    }

    private void DisplayPlayersChoice()
    {
        if (GUI.Button(new Rect(Screen.width - 250, Screen.height - 50, 100, 30), GameInformation.playerMoveOne.AbilityName))
        {
            // calculate the damage player does to enemy
            TurnBasedCombatStateMachine.playerUsedAbility = GameInformation.playerMoveOne;
            TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CALCULATEDAMAGE;
        }

        if (GUI.Button(new Rect(Screen.width - 150, Screen.height - 50, 100, 30), GameInformation.playerMoveTwo.AbilityName))
        {
            // calculate the damage player does to enemy
            TurnBasedCombatStateMachine.playerUsedAbility = GameInformation.playerMoveTwo;
            TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CALCULATEDAMAGE;
        }
    }

    
}
