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

        Vector3 playerPos = gameObject.transform.position;
        playerPos.x = -8.5f;
        playerPos.y = 3.5f;
        playerPos.z = 0.0f;

        player.transform.position = playerPos;


        Collider[] colls = Physics.OverlapSphere(player.transform.position, 7.0f);

        for(int i=0;i<colls.Length;i++)
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

        player.transform.position = playerPos;

        

        player.tag = "Player";

    }

    public void getWizard()
    {
        buyPrefab = Resources.Load<GameObject>("mage_dark");

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

        player.transform.position = playerPos;



        player.tag = "Player";

    }

    public void getArcher()
    {
        buyPrefab = Resources.Load<GameObject>("archer2");

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

        player.transform.position = playerPos;



        player.tag = "Player";

    }


}
