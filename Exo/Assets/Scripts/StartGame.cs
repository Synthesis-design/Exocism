using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    GameObject detect;
    Vector3 detectPos; //적 감지 위치
    Vector3 changePos; //이동 거리

    void Start()
    {
        detectEnemy();
    }

    void Update()
    {

    }

    void detectEnemy()
    {
        GameObject[] knight = GameObject.FindGameObjectsWithTag("Knight");
        GameObject[] Assassin = GameObject.FindGameObjectsWithTag("Assassin");
        GameObject[] Wizard = GameObject.FindGameObjectsWithTag("Wizard");
        GameObject[] Archer = GameObject.FindGameObjectsWithTag("Archer");
        GameObject[] Hwang = GameObject.FindGameObjectsWithTag("Hwang");
        GameObject[] King = GameObject.FindGameObjectsWithTag("King");
        GameObject[] Skeleton = GameObject.FindGameObjectsWithTag("skeleton");
        Debug.Log(knight.Length);
        if (knight != null)
        {
            for (int i = 0; i < knight.Length; i++)
            {
                changePos = knight[i].transform.position;
                detectPos = knight[i].transform.position;
                changePos.x += 1f;
                detectPos.x += 1f;
                for(int j = 0; j < Skeleton.Length;j++)
                {
                    if (Skeleton[j].transform.position == detectPos)
                    {
                        Debug.Log("적 감지!");
                        break;
                    }
                    else
                    {
                        Debug.Log("적 감지 못함!");
                        knight[i].transform.position = detectPos;
                    }
                }
               
            }
            StartCoroutine(defUpdate());
        }
    }
    IEnumerator defUpdate()
    {
        yield return new WaitForSeconds(1.0f);
        detectEnemy();
    }
}
