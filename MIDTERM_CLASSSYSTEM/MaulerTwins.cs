using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaulerTwins : Character
{
    public override void Start()
    {
        name = "MaulerTwins";
        base.Start();
    }

    public override void Select()
    {
        Debug.Log($"You have chosen {name} as your Invincible character!");
    }
}
