using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RileyD_Weapon {

    string name;
    int damage;

    // Constructor
    public RileyD_Weapon(string n, int d)
    {
        name = n;
        damage = d;
    }

    //Properties
    public string Name
    {
        get { return name; }
    }

    public int Damage
    {
        get { return damage; }
    }

}
