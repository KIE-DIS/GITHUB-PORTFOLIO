using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisterFantastic : Character
{
    public override void Start()
    {
        name = "Mister Fantastic";
        base.Start();
    }

    public override void Choose()
    {
        Debug.Log($"You have chosen {name} as your character of choice!");
    }
}
