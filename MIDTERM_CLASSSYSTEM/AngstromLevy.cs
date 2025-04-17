using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngstromLevy : Character
{
    public override void Start()
    {
        name = "AngstromLevy";
        base.Start();
    }

    public override void Select()
    {
        Debug.Log($"You have chosen {name} as your Invincible character!");
    }
}
