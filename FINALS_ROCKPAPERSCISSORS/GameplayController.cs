using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum GameChoices
{
    NONE,
    ROCK,
    PAPER,
    SCISSORS
}

public class GameplayController : MonoBehaviour
{
    [SerializeField]
    private Sprite rockSprite, paperSprite, scissorsSprite;

    [SerializeField]
    private Image playerChoiceIMG, opponentChoiceIMG;

    [SerializeField]
    private TMP_Text infoText;

    private GameChoices playerChoice = GameChoices.NONE, opponentChoice = GameChoices.NONE;

    private AnimationController animationController;

    void Awake()
    {
        animationController = GetComponent<AnimationController>();
    }

    public void SetChoices(GameChoices gameChoices)
    {
        switch(gameChoices)
        {
            case GameChoices.ROCK:
                playerChoiceIMG.sprite = rockSprite;
                playerChoice = GameChoices.ROCK;
                break;

            case GameChoices.PAPER:
                playerChoiceIMG.sprite = paperSprite;
                playerChoice = GameChoices.PAPER;
                break;

            case GameChoices.SCISSORS:
                playerChoiceIMG.sprite = scissorsSprite;
                playerChoice = GameChoices.SCISSORS;
                break;
        }

        SetOpponentChoice();

        DetermineWinner();
    }

    void SetOpponentChoice()
    {
        int rnd = Random.Range(0, 3);

        switch(rnd)
        {
            case 0:
                opponentChoice = GameChoices.ROCK;
                opponentChoiceIMG.sprite = rockSprite;
                break;

            case 1:
                opponentChoice = GameChoices.PAPER;
                opponentChoiceIMG.sprite = paperSprite;
                break;

            case 2:
                opponentChoice = GameChoices.SCISSORS;
                opponentChoiceIMG.sprite = scissorsSprite;
                break;
        }
    }

    void DetermineWinner()
    {
        if (playerChoice == opponentChoice)
        {
            infoText.text = "It's a Draw!";
            StartCoroutine(DisplayWinnerAndRestart());

            return;
        }

        if (playerChoice == GameChoices.PAPER && opponentChoice == GameChoices.ROCK)
        {
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());

            return;
        }

        if (opponentChoice == GameChoices.PAPER && playerChoice == GameChoices.ROCK)
        {
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());

            return;
        }

        if (playerChoice == GameChoices.ROCK && opponentChoice == GameChoices.SCISSORS)
        {
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());

            return;
        }

        if (opponentChoice == GameChoices.ROCK && playerChoice == GameChoices.SCISSORS)
        {
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());

            return;
        }

        if (playerChoice == GameChoices.SCISSORS && opponentChoice == GameChoices.PAPER)
        {
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());

            return;
        }

        if (opponentChoice == GameChoices.SCISSORS && playerChoice == GameChoices.PAPER)
        {
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());

            return;
        }
    }

        IEnumerator DisplayWinnerAndRestart()
    {
        yield return new WaitForSeconds(2f);

        infoText.gameObject.SetActive(true);

        yield return new WaitForSeconds(2f);

        infoText.gameObject.SetActive(false);

        animationController.ResetAnimations();
    }
}
