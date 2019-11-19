using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edit : MonoBehaviour
{
    public bool edit_mode = true;
    Camera cam;
   

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (edit_mode == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 clickPos = new Vector2(worldPos.x, worldPos.y);
                Collider2D clickColl = Physics2D.OverlapPoint(clickPos);
                GameObject hit = Physics2D.OverlapPoint(clickPos).gameObject;

                if (hit.CompareTag("Player"))
                {
                    hit.GetComponent<SpriteOutline>().enabled = true;
                }
            }
        }
    }

}
