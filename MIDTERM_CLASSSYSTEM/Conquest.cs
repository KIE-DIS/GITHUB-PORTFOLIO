using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conquest : Character
{
    public override void Start()
    {
        name = "Conquest";
        base.Start();
    }

    public override void Select()
    {
        Debug.Log($"You have chosen {name} as your Invincible character!");
    }
}
