using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassUsage : MonoBehaviour {

    Villians[] aMyVillians;

	// Use this for initialization
	void Start () {
        CreateVillians();
        for (int i = 0; i < aMyVillians.Length; i++)
        {
            Debug.Log(aMyVillians[i].Name + " Has been in Villiany for " + aMyVillians[i].YrsInVilliany + " years, and has caused $" +
                aMyVillians[i].DmgInMill + " Million in damage.\n");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void CreateVillians()
    {
        aMyVillians = new Villians[]
        {
            new Villians("The Monarch", 14, 2.3f),
            new Villians("Phantom Limb", 35, 1.2f),
            new Villians("Baron Underbhite", 10, .5f),
            new Villians("Doctor Girlfriend", 13, 34.2f),
            new Villians("Torrid", 3,  1.0f)
        };
    }
}
