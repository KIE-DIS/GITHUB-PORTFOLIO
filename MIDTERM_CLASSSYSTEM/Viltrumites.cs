using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Viltrumites : Character
{
    public override void Start()
    {
        name = "Viltrumites";
        base.Start();
    }

    public override void Select()
    {
        Debug.Log($"You have chosen the {name} group!");
    }
}
