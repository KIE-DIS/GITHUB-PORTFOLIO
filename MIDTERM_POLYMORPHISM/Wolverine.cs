using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolverine : Character
{
    public override void Start()
    {
        name = "Wolverine";
        base.Start();
    }

    public override void Choose()
    {
        Debug.Log($"You have chosen {name} as your character of choice!");
    }
}
