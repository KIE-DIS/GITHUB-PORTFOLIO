using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;
using TMPro;

public class RivalsButton : MonoBehaviour
{
    public TextMeshProUGUI heroName;
    public TextMeshProUGUI heroRole;
    public TextMeshProUGUI heroCostume;
    public TextMeshProUGUI heroMVP;
    public TextMeshProUGUI heroEmote;

    private rivalsOOP marvelOOP;
    public rivalsHeroes marvelHeroes;

    public static int counter = 0;

    public void Start()
    {
        marvelOOP = FindObjectOfType<rivalsOOP>();
    }

    public void SetData(rivalsHeroes hero)
    {
        this.heroName.text = hero.heroName;
        this.heroRole.text = hero.heroRole;
        this.heroCostume.text = hero.heroCostume;
        this.heroMVP.text = hero.heroMVP;
        this.heroEmote.text = hero.heroEmote;
    }
}
