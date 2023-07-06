using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial_Level");
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level_One");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level_Two");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level_Three");
    }

    public void Level4()
    {
        SceneManager.LoadScene("Level_Four");
    }
}
