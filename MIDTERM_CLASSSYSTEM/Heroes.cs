using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heroes : Character
{
    public override void Start()
    {
        name = "Heroes";
        base.Start();
    }

    public override void Select()
    {
        Debug.Log($"You have chosen the {name} faction!");
    }
}

