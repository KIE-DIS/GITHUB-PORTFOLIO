using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Villains : Character
{
    public override void Start()
    {
        name = "Villains";
        base.Start();
    }

    public override void Select()
    {
        Debug.Log($"You have chosen the {name} faction!");
    }
}
