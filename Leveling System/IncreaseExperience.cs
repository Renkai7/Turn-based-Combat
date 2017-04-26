using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Handles experience gained and checks if player levels up
public static class IncreaseExperience  {

    private static int expToGive;
    private static LevelUp levelUpScript = new LevelUp();

    // Method to add experience to Player's total amount of experience
	public static void AddExperience()
    {
        // Formula for experience points gained
        expToGive = GameInformation.PlayerLevel * 100;

        GameInformation.CurrentEXP += expToGive;

        CheckIfPlayerLeveledUp();
        Debug.Log(expToGive);
    }

    // Method to check if the player leveled up
   private static void CheckIfPlayerLeveledUp()
   {
        if(GameInformation.CurrentEXP >= GameInformation.RequiredEXP)
        {
            // then the player has leveled up
            levelUpScript.LevelUpCharacter();
            // create level up scrip
        }
    }

    
}
