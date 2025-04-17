using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duelist : Character
{
    public override void Start()
    {
        name = "Duelist";
        base.Start();
    }

    public override void Choose()
    {
        Debug.Log($"You have chosen the {name} role!");
    }
}
