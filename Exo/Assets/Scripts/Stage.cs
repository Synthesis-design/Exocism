using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage : MonoBehaviour
{
    public int money = 5;
    public Text moneyTxt;
    public Text Nomoney;

    // Start is called before the first frame update
    void Start()
    {
        SetTxt();
    }

    // Update is called once per frame
    void Update()
    {
        SetTxt();
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
