using System.Collections;using System.Collections.Generic;using UnityEngine;using UnityEngine.SceneManagement;public class MainMenu : MonoBehaviour{    public AudioSource SFX;    public void PlayGame()    {        SceneManager.LoadScene("Tutorial_Level");    }    public void PickLevel()
    {
        SceneManager.LoadScene("Level_Menu");
    }    public void QuitGame()    {        Debug.Log("Quit");        Application.Quit();    }    public void PlaySound()
    {
        SFX.Play();
    }}
