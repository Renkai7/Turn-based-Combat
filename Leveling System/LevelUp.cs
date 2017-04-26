using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script handles leveling up
// Functions check the current amount of experience and calculate added experience from battle
public class LevelUp : MonoBehaviour {

    // This is the max level the player can reach
    public int maxLevel = 50;

    // Function to level up the character
	public void LevelUpCharacter()
    {
        // Check if current exp is greater than required exp
        if(GameInformation.CurrentEXP > GameInformation.RequiredEXP)
        {
            GameInformation.CurrentEXP -= GameInformation.RequiredEXP;
        }
        else
        {
            GameInformation.CurrentEXP = 0;
        }

        // Checks if player reached max level
        // If player hasn't reached max level then add one level
        if(GameInformation.PlayerLevel < maxLevel)
        {
            GameInformation.PlayerLevel += 1;
        }
        else
        {
            GameInformation.PlayerLevel = maxLevel;
        }

        // give player stat points
        // give player random items
        // give player new moves
        // give money
        // recalculate new required exp
        DetermineRequiredEXP();
    }

    private void DetermineRequiredEXP()
    {
        int temp = (GameInformation.PlayerLevel * 1000) + 250;
        GameInformation.RequiredEXP = temp;
    }

    private void DetermineMoneyGained()
    {
        if(GameInformation.PlayerLevel <= 10)
        {
            // give certain amount of money
        }
    }
}
