using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public System.TimeSpan compareTime;
    public float StartStemina;

    public bool edit_mode = false;

    private void Awake()
    {
        string lastTime = PlayerPrefs.GetString("SaveLastTime");

        System.DateTime lastDateTime = System.DateTime.Parse(lastTime);
        compareTime = System.DateTime.Now - lastDateTime;

        Debug.Log(compareTime.TotalSeconds);

        StartStemina = PlayerPrefs.GetFloat("SteminaNum");
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetString("SaveLastTime", System.DateTime.Now.ToString());

        StartScene ST_S = FindObjectOfType<StartScene>();

        PlayerPrefs.SetFloat("SteminaNum", ST_S.SteminaNum);
    }

    public void OnClickQuit()
    {
        Application.Quit();
    }

    public void OnClickPause()
    {
        Time.timeScale = 0;

        Menu.SetActive(true);
    }

    public void OnClickAgain()
    {
        Time.timeScale = 1;

        Menu.SetActive(false);
    }

    public void OnClickReturn()
    {
        SceneManager.LoadScene("Map");
        Time.timeScale = 1;
    }

    public GameObject Menu;
}
