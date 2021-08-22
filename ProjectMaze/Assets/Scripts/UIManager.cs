using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    public AudioSource click;
   public void Mazeone()
    {
        SceneManager.LoadScene("M1");
        PlaySound();
    }
    public void Mazetwo()
    {
        SceneManager.LoadScene("M2");
        PlaySound();
    }
    public void Mainmenu()
    {
        SceneManager.LoadScene("MainMenu");
        PlaySound();
    }
    public void Exitgame()
    {
        Application.Quit();
        PlaySound();
    }
    public void PlaySound()
    {
        click.Play();
    }

    public void Gamewin()
    {
        SceneManager.LoadScene("GameWin");
        PlaySound();
    }
    public void Gameloose()
    {
        SceneManager.LoadScene("GameOver");
        PlaySound();
    }
}
