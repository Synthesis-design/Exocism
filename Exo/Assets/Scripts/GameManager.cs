using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gotemp;
    public System.TimeSpan compareTime;

    private void Awake()
    {
        string lastTime = PlayerPrefs.GetString("SaveLastTime");

        System.DateTime lastDateTime = System.DateTime.Parse(lastTime);
        compareTime = System.DateTime.Now - lastDateTime;

        Debug.Log(compareTime.TotalSeconds);
        
      
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetString("SaveLastTime", System.DateTime.Now.ToString());
    }
}
