using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Venom : Character
{
    public override void Start()
    {
        name = "Venom";
        base.Start();
    }

    public override void Choose()
    {
        Debug.Log($"You have chosen {name} as your character of choice!");
    }
}
