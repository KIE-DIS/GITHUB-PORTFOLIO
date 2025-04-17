using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Weapon
{
    public override void Start()
    {
        name = "Sword";
        base.Start();
    }

    public override void Attack()
    {
        Debug.Log($"The enemy has been struck by {name}!");
    }
}

