using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMatchingGame : MonoBehaviour
{
    public GameObject ToMatchingGameObject;
    public GameObject SelectMenu;
    public GameObject QuizMenu;
    public GameObject MatchingGame;

    public void GoToMatchingGame()
    {
        MatchingGame.SetActive(true);
        ToMatchingGameObject.SetActive(false);
        QuizMenu.SetActive(false);
    }

    public void BackToMenu()
    {
        ToMatchingGameObject.SetActive(false);
        QuizMenu.SetActive(false);
        SelectMenu.SetActive(true);
    }
}
