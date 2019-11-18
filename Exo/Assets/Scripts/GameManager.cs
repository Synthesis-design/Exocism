using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
<<<<<<< HEAD
<<<<<<< HEAD
    public bool edit_mode = false;
    private void Start()
=======
=======
>>>>>>> 8ca238d7da56d99630020833323fb2aeb83539af
    public System.TimeSpan compareTime;
    public float StartStemina;

    private void Awake()
<<<<<<< HEAD
>>>>>>> 8ca238d7da56d99630020833323fb2aeb83539af
=======
>>>>>>> 8ca238d7da56d99630020833323fb2aeb83539af
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
}
