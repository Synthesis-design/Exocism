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
    string sceneName;

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
            case "stage1":
                money = 5;
                break;
            case "stage2":
                money = 8;
                break;
            case "stage3":
                money = 5;
                break;
            case "stage4":
                money = 8;
                break;
            case "stage5":
                money = 8;
                break;
            case "stage6":
                money = 8;
                break;
            case "stage7":
                money = 8;
                break;
            case "stage8":
                money = 8;
                break;

        }

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
}
