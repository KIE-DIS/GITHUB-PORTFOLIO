using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vanguard : Character
{
    public override void Start()
    {
        name = "Vanguard";
        base.Start();
    }

    public override void Choose()
    {
        Debug.Log($"You have chosen the {name} role!");
    }
}
