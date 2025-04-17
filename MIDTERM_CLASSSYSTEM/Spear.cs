using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : Weapon
{
    public override void Start()
    {
        name = "Spear";
        base.Start();
    }

    public override void Attack()
    {
        Debug.Log($"The enemy has been struck by {name}!");
    }
}

