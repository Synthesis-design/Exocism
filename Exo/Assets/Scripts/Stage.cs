using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage : MonoBehaviour
{
    public int money ;
    public Text moneyTxt;
    public Text Nomoney;
    public Text infomsg1;

    string sceneName;
    Purchase pur;
     // Start is called before the first frame update
    void Start()
    {
        GiveMoney();
        SetTxt();
    }

    // Update is called once per frame
    void Update()
    {
        SetTxt();
    }

    void GiveMoney()
    {
        sceneName = SceneManager.GetActiveScene().name;
        switch (sceneName)
        {
            case "Stage1":
                money = 0;

                break;
            case "Stage2":
                money = 0;
                break;
            case "Stage3":
                money = 0;
                break;
            case "Stage4":
                money = 8;
                break;
            case "Stage5":
                money = 8;
                break;
            case "Stage6":
                money = 8;
                break;
            case "Stage7":
                money = 8;
                break;
            case "Stage8":
                money = 8;
                break;

        }
        StartCoroutine(InfoDelay());

    }

    void StageStart()
    {
    }

    void SetTxt()
    {
        moneyTxt.text = money.ToString();
    }

    public void NoMoneyAlert()
    {
        Debug.Log("알림 뜸");
        Nomoney.enabled = true;
        StartCoroutine(AlertDelay());
        Debug.Log("알림 사라짐");

    }

    IEnumerator AlertDelay()
    {
        yield return new WaitForSeconds(1.0f);
        Nomoney.enabled = false;

    }

    IEnumerator InfoDelay()
    {
        yield return new WaitForSeconds(5.0f);
        infomsg1.enabled = false;
    }

}
