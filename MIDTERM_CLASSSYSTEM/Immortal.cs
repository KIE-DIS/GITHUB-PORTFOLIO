using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Immortal : Character
{
    public override void Start()
    {
        name = "Immortal";
        base.Start();
    }

    public override void Select()
    {
        Debug.Log($"You have chosen {name} as your Invincible character!");
    }
}