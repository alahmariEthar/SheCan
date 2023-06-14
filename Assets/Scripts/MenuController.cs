using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject CreditCanves;
    [SerializeField] private  GameObject MenuCanves;

    public void PlayGame()
    {
        SceneManager.LoadScene("Test");
    }

    public void Credits()
    {
        MenuCanves.SetActive(false);
        CreditCanves.SetActive(true);
    }


    public void Back()
    {
        MenuCanves.SetActive(true);
        CreditCanves.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Title");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
