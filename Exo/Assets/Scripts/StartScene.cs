using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public Text Stemina;
    public float time=0.0f;
    public float SteminaNum=0.0f;
    

    private void Start()
    {
        GameManager GameMgr= FindObjectOfType<GameManager>();

        SteminaNum = GameMgr.StartStemina;
        DateTime(GameMgr.compareTime.TotalSeconds);
    }

    // Update is called once per frame
    private void Update()
    {
        if(SteminaNum<5)
        {
            time += Time.deltaTime;

            if (time > 300.0f && time < 301.0f)
            {
                SteminaNum++;

                Stemina.text = SteminaNum.ToString() + "/5";
                time = 0.0f;
            }
        }
        else
        {
            SteminaNum = 5.0f;
            Stemina.text = SteminaNum.ToString() + "/5";
        }
        
    }

    public void OnAnyBtnClick()
    {
        //Menu.SetActive(true);
        //Info.SetActive(false);
        //Title.SetActive(false);
        SceneManager.LoadScene("Map");
    }
    
    //좀 더 간결하게 코드를 짜는 법은 없을까나
    public void Stage1()
    {
        if (SteminaNum == 0)
            Debug.Log("불가능");
        else
        {
            SceneManager.LoadScene("Stage1");
            Debug.Log("1번째 스테이지 오픈");
            SteminaNum--;
        }
    }
    public void Stage2()
    {
        if (SteminaNum == 0)
            Debug.Log("불가능");
        else
        {
            SceneManager.LoadScene("Stage2");
            Debug.Log("2번째 스테이지 오픈");
            SteminaNum--;
        }
    }
    public void Stage3()
    {
        if (SteminaNum == 0)
            Debug.Log("불가능");
        else
        {
            SceneManager.LoadScene("Stage3");
            Debug.Log("3번째 스테이지 오픈");
            SteminaNum--;
        }
    }
    public void Stage4()
    {
        if (SteminaNum == 0)
            Debug.Log("불가능");
        else
        {
            SceneManager.LoadScene("Stage4");
            Debug.Log("4번째 스테이지 오픈");
            SteminaNum--;
        }
    }
    public void Stage5()
    {
        if (SteminaNum == 0)
            Debug.Log("불가능");
        else
        {
            SceneManager.LoadScene("Stage5");
            Debug.Log("5번째 스테이지 오픈");
            SteminaNum--;
        }
    }

    public void Stage6()
    {
        if (SteminaNum == 0)
            Debug.Log("불가능");
        else
        {
            SceneManager.LoadScene("Stage6");
            Debug.Log("6번째 스테이지 오픈");
            SteminaNum--;
        }
    }

    public void Stage7()
    {
        if (SteminaNum == 0)
            Debug.Log("불가능");
        else
        {
            SceneManager.LoadScene("Stage7");
            Debug.Log("7번째 스테이지 오픈");
            SteminaNum--;
        }
    }

    public void Stage8()
    {
        if (SteminaNum == 0)
            Debug.Log("불가능");
        else
        {
            SceneManager.LoadScene("Stage8");
            Debug.Log("8번째 스테이지 오픈");
            SteminaNum--;
        }
    }

    public void DateTime(double temp)
    {
        if (temp >= 0.0f && temp < 300.0f)
        {
            SteminaNum += 0;
            Stemina.text = SteminaNum.ToString() + "/5";
        }
        else if (temp >= 300.0f && temp<600.0f)
        {
            SteminaNum += 1;
            Stemina.text = SteminaNum.ToString() + "/5";
        }
        else if (temp >= 600.0f && temp < 900.0f)
        {
            SteminaNum += 2;
            Stemina.text = SteminaNum.ToString() + "/5";
        }
        else if (temp >= 900.0f && temp < 1200.0f)
        {
            SteminaNum += 3;
            Stemina.text = SteminaNum.ToString() + "/5";
        }
        else if (temp >= 1200.0f && temp < 1500.0f)
        {
            SteminaNum += 4;
            Stemina.text = SteminaNum.ToString() + "/5";
        }
        else
        {
            SteminaNum += 5;
            Stemina.text = SteminaNum.ToString() + "/5";
        }
    }

    public GameObject Menu;
    public GameObject Title;
    public GameObject Info;
}
