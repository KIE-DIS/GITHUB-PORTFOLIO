using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EliteHeroes : Character
{
    public override void Start()
    {
        name = "EliteHeroes";
        base.Start();
    }

    public override void Select()
    {
        Debug.Log($"You have chosen the {name} group!");
    }
}
