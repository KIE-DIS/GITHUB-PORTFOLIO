using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int MaxNumberOfShots = 3;
    [SerializeField] private float secondsToWaitBeforeDeathCheck = 3f;
    [SerializeField] private GameObject restartGameObject;
    [SerializeField] private SlingshotHandler slingshotHandler;

    private int usedNumberOfShots;

    private IconHandler iconHandler;

    private List<BadPiggies> pPiggies = new List<BadPiggies>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        iconHandler = FindObjectOfType<IconHandler>();

        BadPiggies[] piggies = FindObjectsOfType<BadPiggies>();
        for (int i = 0; i < piggies.Length; i++)
        {
            pPiggies.Add(piggies[i]);
        }
    }

    public void UseShot()
    {
        usedNumberOfShots++;
        iconHandler.UseShot(usedNumberOfShots);

        CheckForLastShot();
    }

    public bool HasEnoughShots()
    {
        if (usedNumberOfShots < MaxNumberOfShots)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void CheckForLastShot()
    {
        if (usedNumberOfShots == MaxNumberOfShots)
        {
            StartCoroutine(CheckAfterWaitTime());
        }
    }

    private IEnumerator CheckAfterWaitTime()
    {
        yield return new WaitForSeconds(secondsToWaitBeforeDeathCheck);

        if (pPiggies.Count == 0)
        {
            WinGame();
        }

        else
        {
            RestartGame();
        }
    }

    public void RemovePiggie(BadPiggies piggie)
    {
        pPiggies.Remove(piggie);
        CheckForAllDeadPiggies();
    }

    private void CheckForAllDeadPiggies()
    {
        if (pPiggies.Count == 0)
        {
            WinGame();
        }
    }

    private void WinGame()
    {
        restartGameObject.SetActive(true);
        slingshotHandler.enabled = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
