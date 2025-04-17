using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketRaccoon : Character
{
    public override void Start()
    {
        name = "Rocket Raccoon";
        base.Start();
    }

    public override void Choose()
    {
        Debug.Log($"You have chosen {name} as your character of choice!");
    }
}
