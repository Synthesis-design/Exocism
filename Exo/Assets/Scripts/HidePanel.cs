using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HidePanel : MonoBehaviour
{
    public GameObject abu;
    public GameObject pur;
    public GameObject Buy;
    public GameObject Info;
    public GameObject btn;
    Button Btn;
    // Start is called before the first frame update
    void Start()
    {
        Btn=btn.transform.GetComponent<Button>();
        Btn.onClick.AddListener(() => activePanel());
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void activePanel()
    {
        bool buy=buyanything();
        if (buy==false)
        { return; }
        else
        {
            Buy.SetActive(false);
            Info.SetActive(false);
            abu.gameObject.SetActive(true);
            pur.gameObject.SetActive(false);
        }
    }

    bool buyanything()
    {
        GameObject[] Knight = GameObject.FindGameObjectsWithTag("Knight");
        GameObject[] Assassin = GameObject.FindGameObjectsWithTag("Assassin");
        GameObject[] Wizard = GameObject.FindGameObjectsWithTag("Wizard");
        GameObject[] Archer = GameObject.FindGameObjectsWithTag("Archer");
        GameObject[] King = GameObject.FindGameObjectsWithTag("King");

        if (Knight.Length == 0 && Assassin.Length == 0 && King.Length == 0 && Wizard.Length == 0 && Archer.Length == 0)
        {
            Buy.SetActive(true);
            return false;
        }
        return true;
    }
}
