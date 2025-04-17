using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Button characterButton;
    [SerializeField]
    private Button heroesButton;
    [SerializeField]
    private Button villainsButton;
    [SerializeField]
    private Button guardiansButton;
    [SerializeField]
    private Button eliteHeroesButton;
    [SerializeField]
    private Button viltrumitesButton;
    [SerializeField]
    private Button eliteVillainsButton;
    [SerializeField]
    private Button immortalButton;
    [SerializeField]
    private Button robotButton;
    [SerializeField]
    private Button atomEveButton;
    [SerializeField]
    private Button invincibleButton;
    [SerializeField]
    private Button conquestButton;
    [SerializeField]
    private Button omniManButton;
    [SerializeField]
    private Button angstromLevyButton;
    [SerializeField]
    private Button maulerTwinsButton;

    void Start()
    {
        characterButton.interactable = true;
        heroesButton.interactable = true;
        villainsButton.interactable = true;
        guardiansButton.interactable = true;
        eliteHeroesButton.interactable = true;
        viltrumitesButton.interactable = true;
        eliteVillainsButton.interactable = true;
        immortalButton.interactable = true;
        robotButton.interactable = true;
        atomEveButton.interactable = true;
        invincibleButton.interactable = true;
        conquestButton.interactable = true;
        omniManButton.interactable = true;
        angstromLevyButton.interactable = true;
        maulerTwinsButton.interactable = true;

        characterButton.onClick.AddListener(() => { characterFunction(); });

        heroesButton.onClick.AddListener(() => { heroesFunction(); });

        villainsButton.onClick.AddListener(() => { villainsFunction(); });

        guardiansButton.onClick.AddListener(() => { guardiansFunction(); });

        eliteHeroesButton.onClick.AddListener(() => { eliteHeroesFunction(); });

        viltrumitesButton.onClick.AddListener(() => { viltrumitesFunction(); });

        eliteVillainsButton.onClick.AddListener(() => { eliteVillainsFunction(); });

        immortalButton.onClick.AddListener(() => { immortalFunction(); });

        robotButton.onClick.AddListener(() => { robotFunction(); });

        atomEveButton.onClick.AddListener(() => { atomEveFunction(); });

        invincibleButton.onClick.AddListener(() => { invincibleFunction(); });

        conquestButton.onClick.AddListener(() => { conquestFunction(); });

        omniManButton.onClick.AddListener(() => { omniManFunction(); });

        angstromLevyButton.onClick.AddListener(() => {angstromLevyFunction(); });

        maulerTwinsButton.onClick.AddListener(() => {maulerTwinsFunction(); });
    }

    void characterFunction()
    {
        characterButton.interactable = true;
        heroesButton.interactable = true;
        villainsButton.interactable = true;
        guardiansButton.interactable = false;
        eliteHeroesButton.interactable = false;
        viltrumitesButton.interactable = false;
        eliteVillainsButton.interactable = false;
        immortalButton.interactable = false;
        robotButton.interactable = false;
        atomEveButton.interactable = false;
        invincibleButton.interactable = false;
        conquestButton.interactable = false;
        omniManButton.interactable = false;
        angstromLevyButton.interactable = false;
        maulerTwinsButton.interactable = false;
    }

    void heroesFunction()
    {
        villainsButton.interactable = false;
        guardiansButton.interactable = true;
        eliteHeroesButton.interactable = true;
        viltrumitesButton.interactable = false;
        eliteVillainsButton.interactable = false;
        immortalButton.interactable = false;
        robotButton.interactable = false;
        atomEveButton.interactable = false;
        invincibleButton.interactable = false;
        conquestButton.interactable = false;
        omniManButton.interactable = false;
        angstromLevyButton.interactable = false;
        maulerTwinsButton.interactable = false;
    }

    void villainsFunction()
    {
        heroesButton.interactable = false;
        guardiansButton.interactable = false;
        eliteHeroesButton.interactable = false;
        viltrumitesButton.interactable = true;
        eliteVillainsButton.interactable = true;
        immortalButton.interactable = false;
        robotButton.interactable = false;
        atomEveButton.interactable = false;
        invincibleButton.interactable = false;
        conquestButton.interactable = false;
        omniManButton.interactable = false;
        angstromLevyButton.interactable = false;
        maulerTwinsButton.interactable = false;
    }

    void guardiansFunction()
    {
        villainsButton.interactable = false;
        eliteHeroesButton.interactable = false;
        viltrumitesButton.interactable = false;
        eliteVillainsButton.interactable = false;
        immortalButton.interactable = true;
        robotButton.interactable = true;
        atomEveButton.interactable = false;
        invincibleButton.interactable = false;
        conquestButton.interactable = false;
        omniManButton.interactable = false;
        angstromLevyButton.interactable = false;
        maulerTwinsButton.interactable = false;
    }

    void eliteHeroesFunction()
    {
        villainsButton.interactable = false;
        viltrumitesButton.interactable = false;
        eliteVillainsButton.interactable = false;
        immortalButton.interactable = false;
        robotButton.interactable = false;
        atomEveButton.interactable = true;
        invincibleButton.interactable = true;
        guardiansButton.interactable = false;
        conquestButton.interactable = false;
        omniManButton.interactable = false;
        angstromLevyButton.interactable = false;
        maulerTwinsButton.interactable = false;
    }

    void viltrumitesFunction()
    {
        heroesButton.interactable = false;
        guardiansButton.interactable = false;
        eliteHeroesButton.interactable = false;
        eliteVillainsButton.interactable = false;
        immortalButton.interactable = false;
        robotButton.interactable = false;
        atomEveButton.interactable = false;
        invincibleButton.interactable = false;
        conquestButton.interactable = true;
        omniManButton.interactable = true;
        angstromLevyButton.interactable = false;
        maulerTwinsButton.interactable = false;
    }
    
    void eliteVillainsFunction()
    {
        heroesButton.interactable = false;
        guardiansButton.interactable = false;
        eliteHeroesButton.interactable = false;
        viltrumitesButton.interactable = false;
        immortalButton.interactable = false;
        robotButton.interactable = false;
        atomEveButton.interactable = false;
        invincibleButton.interactable = false;
        conquestButton.interactable = false;
        omniManButton.interactable = false;
        angstromLevyButton.interactable = true;
        maulerTwinsButton.interactable = true;
    }

    void immortalFunction()
    {
        villainsButton.interactable = false;
        eliteHeroesButton.interactable = false;
        viltrumitesButton.interactable = false;
        eliteVillainsButton.interactable = false;
        robotButton.interactable = false;
        atomEveButton.interactable = false;
        invincibleButton.interactable = false;
        conquestButton.interactable = false;
        omniManButton.interactable = false;
        angstromLevyButton.interactable = false;
        maulerTwinsButton.interactable = false;
    }

    void robotFunction()
    {
        villainsButton.interactable = false;
        eliteHeroesButton.interactable = false;
        viltrumitesButton.interactable = false;
        eliteVillainsButton.interactable = false;
        immortalButton.interactable = false;
        atomEveButton.interactable = false;
        invincibleButton.interactable = false;
        conquestButton.interactable = false;
        omniManButton.interactable = false;
        angstromLevyButton.interactable = false;
        maulerTwinsButton.interactable = false;
    }

    void atomEveFunction()
    {
        villainsButton.interactable = false;
        guardiansButton.interactable = false;
        viltrumitesButton.interactable = false;
        eliteVillainsButton.interactable = false;
        immortalButton.interactable = false;
        robotButton.interactable = false;
        invincibleButton.interactable = false;
        conquestButton.interactable = false;
        omniManButton.interactable = false;
        angstromLevyButton.interactable = false;
        maulerTwinsButton.interactable = false;
    }

    void invincibleFunction()
    {
        villainsButton.interactable = false;
        guardiansButton.interactable = false;
        viltrumitesButton.interactable = false;
        eliteVillainsButton.interactable = false;
        immortalButton.interactable = false;
        robotButton.interactable = false;
        atomEveButton.interactable = false;
        conquestButton.interactable = false;
        omniManButton.interactable = false;
        angstromLevyButton.interactable = false;
        maulerTwinsButton.interactable = false;
    }

    void conquestFunction()
    {
        heroesButton.interactable = false;
        guardiansButton.interactable = false;
        eliteHeroesButton.interactable = false;
        immortalButton.interactable = false;
        robotButton.interactable = false;
        atomEveButton.interactable = false;
        invincibleButton.interactable = false;
        omniManButton.interactable = false;
        angstromLevyButton.interactable = false;
        maulerTwinsButton.interactable = false;
    }

    void omniManFunction()
    {
        heroesButton.interactable = false;
        guardiansButton.interactable = false;
        eliteHeroesButton.interactable = false;
        immortalButton.interactable = false;
        robotButton.interactable = false;
        atomEveButton.interactable = false;
        invincibleButton.interactable = false;
        conquestButton.interactable = false;
        angstromLevyButton.interactable = false;
        maulerTwinsButton.interactable = false;
    }

    void angstromLevyFunction()
    {
        heroesButton.interactable = false;
        guardiansButton.interactable = false;
        eliteHeroesButton.interactable = false;
        immortalButton.interactable = false;
        robotButton.interactable = false;
        atomEveButton.interactable = false;
        invincibleButton.interactable = false;
        conquestButton.interactable = false;
        omniManButton.interactable = false;
        maulerTwinsButton.interactable = false;
    }

    void maulerTwinsFunction()
    {
        heroesButton.interactable = false;
        guardiansButton.interactable = false;
        eliteHeroesButton.interactable = false;
        viltrumitesButton.interactable = false;
        immortalButton.interactable = false;
        robotButton.interactable = false;
        atomEveButton.interactable = false;
        invincibleButton.interactable = false;
        conquestButton.interactable = false;
        omniManButton.interactable = false;
        angstromLevyButton.interactable = false;
    }
}
