using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGUI : MonoBehaviour {

    private BaseCharacterClass class1 = new BaseHeroClass();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        GUILayout.Label("Name: " + class1.CharacterName);
        GUILayout.Label("Description: " + class1.CharacterClassDescription);
        GUILayout.Label("Strength: " + class1.Strength.ToString());
        GUILayout.Label("Magic: " + class1.Magic.ToString());
        GUILayout.Label("Endurance: " + class1.Endurance.ToString());
        GUILayout.Label("Agility: " + class1.Agility.ToString());
        GUILayout.Label("Luck: " + class1.Luck.ToString());
    }
}
