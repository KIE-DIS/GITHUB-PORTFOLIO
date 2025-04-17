using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;
using TMPro;

[System.Serializable]

public class rivalsHeroes
{
    public string heroName;
    public string heroRole;
    public string heroCostume;
    public string heroMVP;
    public string heroEmote;

    public rivalsHeroes(string heroName, string heroRole, string heroCostume, string heroMVP, string heroEmote)
    {
        this.heroName = heroName;
        this.heroRole = heroRole;
        this.heroCostume = heroCostume;
        this.heroMVP = heroMVP;
        this.heroEmote = heroEmote;
    }
}