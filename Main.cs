using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RileyDavid4_1 : MonoBehaviour {

    RileyD_Weapon[] NPC_Weapon;
    RileyD_NPC[] NPC_Stats;

	// Use this for initialization
	void Start () {
        createWeapons();
        createNPCs();

        for (int i = 0; i < NPC_Weapon.Length; i++)
        {
            Debug.Log(NPC_Stats[i].Name + " uses the \"" + NPC_Stats[i].Weapon.Name + "\" weapon, \n" + 
                      "which deals " + NPC_Stats[i].Weapon.Damage + "HP in Damage");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void createWeapons()
    {
        NPC_Weapon = new RileyD_Weapon[]
        {
            new RileyD_Weapon ("The Gut Buster", 10),
            new RileyD_Weapon ("My Little Friend", 30),
            new RileyD_Weapon ("Little Doctor", 100),
            new RileyD_Weapon ("Girl", 400)
        };
    }

    void createNPCs()
    {
        NPC_Stats = new RileyD_NPC[]
        {
            new RileyD_NPC ("Alfred", NPC_Weapon[0]),
            new RileyD_NPC ("Casy", NPC_Weapon[1]),
            new RileyD_NPC ("Portia", NPC_Weapon[2]),
            new RileyD_NPC ("Chan", NPC_Weapon[3])
        };
    }
}
