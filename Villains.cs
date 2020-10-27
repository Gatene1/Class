using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villians {

    string name;
    int yrsInVilliany;
    float dmgInMill;

    //Constructor
    public Villians(string n, int y,  float d)
    {
        name = n;
        yrsInVilliany = y;
        dmgInMill = d;
    }

    //Poperties
	public string Name
    {
        get { return name; }
    }

    public int YrsInVilliany
    {
        get { return yrsInVilliany; }
    }

    public float DmgInMill
    {
        get { return dmgInMill; }
    }
}
