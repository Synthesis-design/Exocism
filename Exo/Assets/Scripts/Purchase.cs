using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Purchase : MonoBehaviour
{
    GameObject buyPrefab;
    public Transform gridPos;
    
    Stage stage;

    int cost; 

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
        stage = GameObject.Find("Canvas").GetComponent<Stage>();

        cost = 1;
        if ((stage.money - cost) >= 0)
        { stage.money = stage.money - cost; }
        else
        {
            Debug.Log("돈 없음");
            stage.NoMoneyAlert();
            return;
        }

  

        buyPrefab = Resources.Load<GameObject>("Knight");
        
        GameObject player = Instantiate(buyPrefab) as GameObject;

        Vector3 playerPos = gameObject.transform.position;
        playerPos.x = -8.5f;
        playerPos.y = 3.5f;
        playerPos.z = 0.0f;

        player.transform.position = playerPos;


        Collider[] colls = Physics.OverlapSphere(player.transform.position, 7.0f);

        for(int i=0;i<colls.Length;i++)
        {
            playerPos.y = playerPos.y - 1f;
            if (playerPos.y < -2.5)
            {
                playerPos.x = playerPos.x + 1f;
                playerPos.y = 3.5f;
                Debug.Log("다시 되돌아옴");
            }
        }

        player.AddComponent<BoxCollider>();
        player.GetComponent<SpriteRenderer>().material = Resources.Load("Outline", typeof(Material)) as Material;
        player.AddComponent<Drag>();
        player.AddComponent<Knight>();

        player.transform.position = playerPos;

        

        player.tag = "Knight";


    }

    public void getWizard()
    {
        stage = GameObject.Find("Canvas").GetComponent<Stage>();

        cost = 2;
        if ((stage.money - cost) >= 0)
        { stage.money = stage.money - cost; }
        else
        {
            Debug.Log("돈 없음");
            stage.NoMoneyAlert();
            return;
        }

        buyPrefab = Resources.Load<GameObject>("Wizard");

        GameObject player = Instantiate(buyPrefab) as GameObject;

        Vector3 playerPos = gameObject.transform.position;
        playerPos.x = -8.5f;
        playerPos.y = 3.5f;
        playerPos.z = 0.0f;

        player.transform.position = playerPos;


        Collider[] colls = Physics.OverlapSphere(player.transform.position, 7.0f);

        for (int i = 0; i < colls.Length; i++)
        {
            playerPos.y = playerPos.y - 1f;
            Debug.Log(playerPos.y);
            if (playerPos.y < -2.5)
            {
                playerPos.x = playerPos.x + 1f;
                playerPos.y = 3.5f;
                Debug.Log("다시 되돌아옴");
            }
        }

        player.AddComponent<BoxCollider>();
        player.GetComponent<SpriteRenderer>().material = Resources.Load("Outline", typeof(Material)) as Material;
        player.AddComponent<Drag>();
        player.AddComponent<Wizard>();

        player.transform.position = playerPos;



        player.tag = "Wizard";

    }

    public void getArcher()
    {
        stage = GameObject.Find("Canvas").GetComponent<Stage>();

        cost = 2;
        if ((stage.money - cost) >= 0)
        { stage.money = stage.money - cost; }
        else
        {
            Debug.Log("돈 없음");
            stage.NoMoneyAlert();
            return;
        }

        buyPrefab = Resources.Load<GameObject>("Archer");

        GameObject player = Instantiate(buyPrefab) as GameObject;

        Vector3 playerPos = gameObject.transform.position;
        playerPos.x = -8.5f;
        playerPos.y = 3.5f;
        playerPos.z = 0.0f;

        player.transform.position = playerPos;


        Collider[] colls = Physics.OverlapSphere(player.transform.position, 7.0f);

        for (int i = 0; i < colls.Length; i++)
        {
            playerPos.y = playerPos.y - 1f;
            Debug.Log(playerPos.y);
            if (playerPos.y < -2.5)
            {
                playerPos.x = playerPos.x + 1f;
                playerPos.y = 3.5f;
                Debug.Log("다시 되돌아옴");
            }
        }

        player.AddComponent<BoxCollider>();
        player.GetComponent<SpriteRenderer>().material = Resources.Load("Outline", typeof(Material)) as Material;
        player.AddComponent<Drag>();
        player.AddComponent<Archer>();

        player.transform.position = playerPos;



        player.tag = "Archer";

    }

    public void getAssassin()
    {
        stage = GameObject.Find("Canvas").GetComponent<Stage>();

        cost = 3;
        if ((stage.money - cost) >= 0)
        { stage.money = stage.money - cost; }
        else
        {
            Debug.Log("돈 없음");
            stage.NoMoneyAlert();
            return;
        }



        buyPrefab = Resources.Load<GameObject>("Assassin");

        GameObject player = Instantiate(buyPrefab) as GameObject;

        Vector3 playerPos = gameObject.transform.position;
        playerPos.x = -8.5f;
        playerPos.y = 3.5f;
        playerPos.z = 0.0f;

        player.transform.position = playerPos;


        Collider[] colls = Physics.OverlapSphere(player.transform.position, 7.0f);

        for (int i = 0; i < colls.Length; i++)
        {
            playerPos.y = playerPos.y - 1f;
            Debug.Log(playerPos.y);
            if (playerPos.y < -2.5)
            {
                playerPos.x = playerPos.x + 1f;
                playerPos.y = 3.5f;
                Debug.Log("다시 되돌아옴");
            }
        }

        player.AddComponent<BoxCollider>();
        player.GetComponent<SpriteRenderer>().material = Resources.Load("Outline", typeof(Material)) as Material;
        player.AddComponent<Drag>();
        player.AddComponent<Assassin>();

        player.transform.position = playerPos;



        player.tag = "Assassin";


    }

    public void getHwang()
    {
        stage = GameObject.Find("Canvas").GetComponent<Stage>();

        cost = 1;
        if ((stage.money - cost) >= 0)
        { stage.money = stage.money - cost; }
        else
        {
            Debug.Log("돈 없음");
            stage.NoMoneyAlert();
            return;
        }

        buyPrefab = Resources.Load<GameObject>("Hwang");

        GameObject player = Instantiate(buyPrefab) as GameObject;

        Vector3 playerPos = gameObject.transform.position;
        playerPos.x = -8.5f;
        playerPos.y = 3.5f;
        playerPos.z = 0.0f;

        player.transform.position = playerPos;


        Collider[] colls = Physics.OverlapSphere(player.transform.position, 7.0f);

        for (int i = 0; i < colls.Length; i++)
        {
            playerPos.y = playerPos.y - 1f;
            Debug.Log(playerPos.y);
            if (playerPos.y < -2.5)
            {
                playerPos.x = playerPos.x + 1f;
                playerPos.y = 3.5f;
                Debug.Log("다시 되돌아옴");
            }
        }

        player.AddComponent<BoxCollider>();
        player.GetComponent<SpriteRenderer>().material = Resources.Load("Outline", typeof(Material)) as Material;
        player.AddComponent<Drag>();
        player.AddComponent<Hwang>();

        player.transform.position = playerPos;



        player.tag = "Hwang";

    }

    public void getKing()
    {
        stage = GameObject.Find("Canvas").GetComponent<Stage>();

        cost = 4;
        if ((stage.money - cost) >= 0)
        { stage.money = stage.money - cost; }
        else
        {
            Debug.Log("돈 없음");
            stage.NoMoneyAlert();
            return;
        }

        buyPrefab = Resources.Load<GameObject>("King");

        GameObject player = Instantiate(buyPrefab) as GameObject;

        Vector3 playerPos = gameObject.transform.position;
        playerPos.x = -8.5f;
        playerPos.y = 3.5f;
        playerPos.z = 0.0f;

        player.transform.position = playerPos;


        Collider[] colls = Physics.OverlapSphere(player.transform.position, 7.0f);

        for (int i = 0; i < colls.Length; i++)
        {
            playerPos.y = playerPos.y - 1f;
            Debug.Log(playerPos.y);
            if (playerPos.y < -2.5)
            {
                playerPos.x = playerPos.x + 1f;
                playerPos.y = 3.5f;
                Debug.Log("다시 되돌아옴");
            }
        }

        player.AddComponent<BoxCollider>();
        player.GetComponent<SpriteRenderer>().material = Resources.Load("Outline", typeof(Material)) as Material;
        player.AddComponent<Drag>();
        player.AddComponent<King>();

        player.transform.position = playerPos;



        player.tag = "King";

    }




}
