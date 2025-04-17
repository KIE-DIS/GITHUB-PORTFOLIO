using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guardians : Character
{
    public override void Start()
    {
        name = "Guardians";
        base.Start();
    }

    public override void Select()
    {
        Debug.Log($"You have chosen the {name} group!");
    }
}
