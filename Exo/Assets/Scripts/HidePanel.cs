using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HidePanel : MonoBehaviour
{
    public GameObject abu;
    public GameObject pur;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activePanel()
    {
        abu = GameObject.Find("Canvas").transform.Find("InGame").gameObject;
        pur = GameObject.Find("BtnPanel").gameObject;
        abu.gameObject.SetActive(true);
        pur.gameObject.SetActive(false);
    }
}
