using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;
using TMPro;

public class RivalsDatabase : MonoBehaviour
{
    public GameObject rivalsNameplate;

    public TextMeshProUGUI marvelName;
    public TextMeshProUGUI marvelRole;
    public TextMeshProUGUI marvelCostume;
    public TextMeshProUGUI marvelMVP;
    public TextMeshProUGUI marvelEmote;

    public void OpenRivalsNameplate(rivalsHeroes hero)
    {
        rivalsNameplate.gameObject.SetActive(true);

        marvelName.text = hero.heroName;
        marvelRole.text = hero.heroRole;
        marvelCostume.text = hero.heroCostume;
        marvelMVP.text = hero.heroMVP;
        marvelEmote.text = hero.heroEmote;
    }

    public void CloseRivalsNameplate()
    {
        rivalsNameplate.gameObject.SetActive(false);
    }
}
