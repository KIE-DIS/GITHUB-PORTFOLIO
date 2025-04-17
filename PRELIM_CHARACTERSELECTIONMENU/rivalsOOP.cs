using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;
using TMPro;

public class rivalsOOP : MonoBehaviour
{
    public GameObject buttonPrefab;
    public Transform buttonContainer;
    public List<rivalsHeroes> rivalsRoster = new List<rivalsHeroes>();
    public RivalsDatabase rivalsDatabase;

    public void Start()
    {
        rivalsDatabase = FindObjectOfType<RivalsDatabase>();
        rivalsRoster.Clear();

        rivalsHeroes humanTorch = new rivalsHeroes ("Human Torch", "Duelist", "Default, Blood Blaze, First Family, Negative Zone Gladiator", "Default, Light Brigade Leader", "Default, Insect Killer");

        rivalsHeroes invisibleWoman = new rivalsHeroes ("Invisible Woman", "Strategist", "Default, Blood Shield, First Family, Malice, The Life Fantastic", "Default, Malicious Whirlwind, Infinite Promise", "Default, Inner Turmoil, I Do");

        rivalsHeroes misterFantastic = new rivalsHeroes ("Mister Fantastic", "Duelist", "Default, First Family, The Maker, The Life Fantastic", "Default, Surging Darkness, Infinite Promise", "Default, Double Impact, Will You?, Missed Chance");

        rivalsHeroes theThing = new rivalsHeroes ("The Thing", "Vanguard", "Default, First Family, Trench Coat", "Default, Noir Scars", "Default, Falling Object");

        rivalsRoster.Add(humanTorch);
        rivalsRoster.Add(invisibleWoman);
        rivalsRoster.Add(misterFantastic);
        rivalsRoster.Add(theThing);

        foreach (rivalsHeroes i in rivalsRoster)
        {
            createButton(i);
        }
    }

    public void createButton(rivalsHeroes hero)
    {
        GameObject heroButton = Instantiate(buttonPrefab, buttonContainer);
        RivalsButton rivalsButton = heroButton.GetComponent<RivalsButton>();
        Button button = rivalsButton.GetComponent<Button>();

        button.onClick.AddListener(() => OnClickHeroButton(hero));
        rivalsButton.SetData(hero);
    }

    public void OnClickHeroButton(rivalsHeroes hero)
    {
        if (hero.heroName != "")
        {
            Debug.Log($"Galacta has added {hero.heroName} to the multiverse!");
            rivalsDatabase.OpenRivalsNameplate(hero);
        }
    }
}
