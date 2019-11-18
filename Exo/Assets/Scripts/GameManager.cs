using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        System.DateTime nowTime = System.DateTime.Now;
        Debug.Log(nowTime.Hour);
        Debug.Log(nowTime.Minute);
        Debug.Log(nowTime.Second);
    }
}
