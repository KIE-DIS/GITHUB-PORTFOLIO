using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strategist : Character
{
    public override void Start()
    {
        name = "Strategist";
        base.Start();
    }

    public override void Choose()
    {
        Debug.Log($"You have chosen the {name} role!");
    }
}
