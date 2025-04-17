using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : Character
{
    public override void Start()
    {
        name = "Robot";
        base.Start();
    }

    public override void Select()
    {
        Debug.Log($"You have chosen {name} as your Invincible character!");
    }
}
