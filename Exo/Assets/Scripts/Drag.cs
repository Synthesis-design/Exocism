using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    private Vector3 screenSpace;
    private Vector3 offset;
    private void OnMouseDown()
    {
        Debug.Log("터치");
        screenSpace = Camera.main.WorldToScreenPoint(transform.position);
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z));

    }

    private void OnMouseDrag()
    {
        var curScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z);
        var curPos = Camera.main.ScreenToWorldPoint(curScreenSpace) + offset;
        if (curPos.x > -9.5f && curPos.x < -0.5f && curPos.y > -3.5f && curPos.y < 3.5f)
        {
            Debug.Log(curPos.x);
            Debug.Log(curPos.y);
            curPos.x = Mathf.Round(curPos.x) + 0.5f;
            curPos.y = Mathf.Round(curPos.y) + 0.5f;
            transform.position = curPos;
        }
        else
        {
            Debug.Log("범위를 벗어났습니다.");
        }
    }
    private void OnMouseUp()
    {
        
    }

}
