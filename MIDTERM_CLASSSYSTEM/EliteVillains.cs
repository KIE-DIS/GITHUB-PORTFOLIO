using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EliteVillains : Character
{
    public override void Start()
    {
        name = "EliteVillains";
        base.Start();
    }

    public override void Select()
    {
        Debug.Log($"You have chosen the {name} group!");
    }
}
