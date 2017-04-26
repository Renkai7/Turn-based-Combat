using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInformation : MonoBehaviour {

    // Not 100% sure what this is for but...
    // Holds information on stats

    // Storage of game information - player name, 

	void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public static List<BaseAbilities> playerAbilities; // List of Abilities

    public static string PlayerName { get; set; }
    public static int PlayerLevel { get; set; }
    public static int PlayerHealth { get; set; }
    public static int CurrentEXP { get; set; }
    public static int RequiredEXP { get; set; }

    public static BaseAbilities playerMoveOne = new AttackAbility();
    public static BaseAbilities playerMoveTwo = new SwordSlash();
}
