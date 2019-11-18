using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Purchase : MonoBehaviour
{
    GameObject buyPrefab;
    public Transform gridPos;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getKnight()
    {
        buyPrefab = Resources.Load<GameObject>("knight");
        
        GameObject player = Instantiate(buyPrefab);

        RectTransform playerPos = player.GetComponent<RectTransform>();

        player.transform.position = gameObject.transform.position;
    }

    public void getWizard()
    {
        buyPrefab = Resources.Load<GameObject>("mage_dark");

        GameObject player = Instantiate(buyPrefab);

        RectTransform playerPos = player.GetComponent<RectTransform>();

        player.transform.position = gameObject.transform.position;

    }

    public void getArcher()
    {
        buyPrefab = Resources.Load<GameObject>("archer2");

        GameObject player = Instantiate(buyPrefab);

        RectTransform playerPos = player.GetComponent<RectTransform>();

        player.transform.position = gameObject.transform.position;

    }


}
