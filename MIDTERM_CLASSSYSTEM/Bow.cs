using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : Weapon
{
    public override void Start()
    {
        name = "Bow";
        base.Start();
    }

    public override void Attack()
    {
        Debug.Log($"The enemy has been struck by {name}!");
    }
}
