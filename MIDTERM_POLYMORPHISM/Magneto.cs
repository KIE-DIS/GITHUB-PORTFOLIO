using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magneto : Character
{
    public override void Start()
    {
        name = "Magneto";
        base.Start();
    }

    public override void Choose()
    {
        Debug.Log($"You have chosen {name} as your character of choice!");
    }
}
