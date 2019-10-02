using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

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
        SceneManager.LoadScene("Stage1");
        Debug.Log("1번째 스테이지 오픈");
    }
    public void Stage2()
    {
        SceneManager.LoadScene("Stage2");
        Debug.Log("2번째 스테이지 오픈");
    }
    public void Stage3()
    {
        SceneManager.LoadScene("Stage3");
        Debug.Log("3번째 스테이지 오픈");
    }
    public void Stage4()
    {
        SceneManager.LoadScene("Stage4");
        Debug.Log("4번째 스테이지 오픈");
    }
    public void Stage5()
    {
        SceneManager.LoadScene("Stage5");
        Debug.Log("5번째 스테이지 오픈");
    }

    public GameObject Menu;
    public GameObject Title;
    public GameObject Info;
}
