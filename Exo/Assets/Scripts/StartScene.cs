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

    // Update is called once per frame
    private void Update()
    {
        if(SteminaNum<5)
        {
            time += Time.deltaTime;

            if (time > 5.0f && time < 6.0f)
            {
                SteminaNum++;

                Stemina.text = SteminaNum.ToString() + "/5";
                time = 0.0f;
            }
        }
        
    }

    public void OnAnyBtnClick()
    {
        Menu.SetActive(true);
        Info.SetActive(false);
        Title.SetActive(false);
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

    public GameObject Menu;
    public GameObject Title;
    public GameObject Info;
}
