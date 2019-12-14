using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Purchase : MonoBehaviour
{
    GameObject buyPrefab;
    public Transform gridPos;

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
        
        GameObject player = Instantiate(buyPrefab) as GameObject;
        GameObject objChk;
        float insX = -8.5f;
        float insY = 3.5f;


        player.AddComponent<SpriteOutline>();
        player.GetComponent<SpriteOutline>().enabled = false;
        player.AddComponent<BoxCollider2D>();
        player.GetComponent<SpriteRenderer>().material = Resources.Load("Outline", typeof(Material)) as Material;
        player.AddComponent<Drag>();
        

        player.tag = "Player";

    }

    public void getWizard()
    {
        buyPrefab = Resources.Load<GameObject>("mage_dark");

        GameObject player = Instantiate(buyPrefab) as GameObject;

        player.AddComponent<SpriteOutline>();
        player.GetComponent<SpriteOutline>().enabled = false;
        player.AddComponent<BoxCollider2D>();
        player.GetComponent<SpriteRenderer>().material = Resources.Load("Outline", typeof(Material)) as Material;
        player.AddComponent<Drag>();

        player.tag = "Player";

    }

    public void getArcher()
    {
        buyPrefab = Resources.Load<GameObject>("archer2");

        GameObject player = Instantiate(buyPrefab) as GameObject;

        player.AddComponent<SpriteOutline>();
        player.GetComponent<SpriteOutline>().enabled = false;
        player.AddComponent<BoxCollider2D>();
        player.GetComponent<SpriteRenderer>().material = Resources.Load("Outline", typeof(Material)) as Material;
        player.AddComponent<Drag>();

        player.tag = "Player";

    }


}
