using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    GameObject detect;
    Vector3[] detectPos; //적 감지 위치
    Vector3 changePos; //이동 거리
    float chKnightDir = 1f;
    float chArcherDir = 1f;
    float chHwangDir = 1f;
    float chAssassinDir = 1f;
    float chWizardDirx = 1f;
    float chWizardDiry = 1f;
    int Jumpcnt = 0;

    void Start()
    {
        detectEnemy();
    }

    void Update()
    {

    }

    void detectEnemy()
    {
        GameObject[] Knight = GameObject.FindGameObjectsWithTag("Knight");
        GameObject[] Assassin = GameObject.FindGameObjectsWithTag("Assassin");
        GameObject[] Wizard = GameObject.FindGameObjectsWithTag("Wizard");
        GameObject[] Archer = GameObject.FindGameObjectsWithTag("Archer");
        GameObject[] Hwang = GameObject.FindGameObjectsWithTag("Hwang");
        GameObject[] King = GameObject.FindGameObjectsWithTag("King");
        GameObject[] Skeleton = GameObject.FindGameObjectsWithTag("skeleton");

        if (Knight != null)
        {
            detectPos = new Vector3[4];
            for (int i = 0; i < Knight.Length; i++)
            {
                KnightMove(Knight[i], Skeleton);
            }
        }
        
        if (Archer != null)
        {
            detectPos = new Vector3[10];
            for (int i = 0; i < Archer.Length; i++) {
                ArcherMove(Archer[i], Skeleton);
            } 
        }

        if (Hwang != null)
        {
            detectPos = new Vector3[2];
            for (int i = 0; i < Hwang.Length; i++)
            {
                HwangMove(Hwang[i], Knight, Assassin, Archer, Hwang, Wizard, King);
            }
        }

        if (Assassin != null)
        {
            detectPos = new Vector3[5];
            for (int i = 0; i < Assassin.Length; i++)
            {
                AssassinMove(Assassin[i], Skeleton);
            }
        }

        if (Wizard != null)
        {
            detectPos = new Vector3[9];
            for (int i = 0; i < Wizard.Length; i++)
            {
                WizardMove(Wizard[i], Skeleton);
            }
        }

        StartCoroutine(defUpdate());
    }

    void KnightMove(GameObject Knight, GameObject[] Skeleton)
    {
        changePos = Knight.transform.position;
        
        if (Knight.transform.position.x == 8.5f)
        {

            chKnightDir = -1f;
        }
        else if (Knight.transform.position.x == -8.5f)
        {
            chKnightDir = 1f;
        }

        for (int k = 0; k < 2; k++)
        {
            detectPos[k] = Knight.transform.position;
        }

        detectPos[0].x += 1f;
        detectPos[1].x += 1f;
        detectPos[2].x += 1f;
        detectPos[0].y += 1f;
        detectPos[2].y -= 1f;
        detectPos[3].x -= 1f;

        changePos.x += chKnightDir;

        for (int t = 0; t < Skeleton.Length; t++)
        {
            for (int k = 0; k < 4; k++)
            {
                if (Skeleton[t].transform.position == detectPos[k])
                {
                    return;
                }
            }
        }

        Knight.transform.position = changePos;

    }

    void HwangMove(GameObject Hwang, GameObject[] Knight, GameObject[] Assassin, GameObject[] Archer, GameObject[] oHwang, GameObject[] Wizard, GameObject[] King)
    {
        changePos = Hwang.transform.position;

        if (Hwang.transform.position.x == 8.5f)
        {
            chHwangDir = -1f;
        }
        else if (Hwang.transform.position.x == -8.5f)
        {
            chHwangDir = 1f;
        }

        for (int k = 0; k < 2; k++)
        {
            detectPos[k] = Hwang.transform.position;
        }
        detectPos[0].x += 1f;
        detectPos[1].x -= 1f;

        changePos.x += chHwangDir;

        for (int t = 0; t < Knight.Length; t++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (Knight[t].transform.position == detectPos[j])
                {
                    return;
                }
            }
        }

        for (int t = 0; t < Assassin.Length; t++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (Assassin[t].transform.position == detectPos[j])
                {
                    return;
                }
            }
        }

        for (int t = 0; t < Archer.Length; t++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (Archer[t].transform.position == detectPos[j])
                {
                    return;
                }
            }
        }

        for (int t = 0; t < oHwang.Length; t++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (oHwang[t].transform.position == detectPos[j])
                {
                    return;
                }
            }
        }

        for (int t = 0; t < Wizard.Length; t++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (Wizard[t].transform.position == detectPos[j])
                {
                    return;
                }
            }
        }

        for (int t = 0; t < King.Length; t++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (King[t].transform.position == detectPos[j])
                {
                    return;
                }
            }
        }

        Hwang.transform.position = changePos;

    }

    void ArcherMove(GameObject Archer, GameObject[] Skeleton)
    {

        changePos = Archer.transform.position;
        if (Archer.transform.position.y == 3.5f)
        {

            chArcherDir = -1f;
        }
        else if (Archer.transform.position.y == -2.5f)
        {
            chArcherDir = 1f;
        }

        for (int k = 0; k < 10; k++)
        {
            detectPos[k] = Archer.transform.position;
        }
        for (int k = 0; k < 10; k++)
        {
            detectPos[k].x += k+1f;
        }


        changePos.y += chArcherDir;

        for (int j = 0; j < Skeleton.Length; j++)
        {
            for (int k = 0; k < 10; k++)
            {
                if (Skeleton[j].transform.position == detectPos[k])
                {

                    return;
                }
            }
        }

        Archer.transform.position = changePos;

    }

    void AssassinMove(GameObject Assassin, GameObject[] Skeleton)
    {
        changePos = Assassin.transform.position;

        if (Assassin.transform.position.x == 8.5f)
        {
            chAssassinDir = -1f;
        }
        else if (Assassin.transform.position.x == -8.5f)
        {
            chAssassinDir = 1f;
        }

        for (int k = 0; k < 5; k++)
        {
            detectPos[k] = Assassin.transform.position;
        }
        for(int k =0; k < 4; k++)
        {
            detectPos[k].x += k + 1f;
            Debug.Log(detectPos[k]);
        }
        detectPos[4].x -= 1f;

        changePos.x += chAssassinDir;

        for (int t = 0; t < Skeleton.Length; t++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (Skeleton[t].transform.position == detectPos[j])
                {
                    if (Jumpcnt == 0 && Skeleton[t].transform.position.x!=8.5f && Skeleton[t].transform.position.x != -8.5f)
                    {
                        detectPos[0] = Skeleton[t].transform.position;
                        detectPos[0].x += 1f;
                        Assassin.transform.position = detectPos[0];
                        Jumpcnt++;

                        return;
                    }
                    return;
                }
            }
        }

        Assassin.transform.position = changePos;

    }

    void WizardMove(GameObject Wizard, GameObject[] Skeleton)
    {
        changePos = Wizard.transform.position;

        if (Wizard.transform.position.x == 8.5f)
        {
            chWizardDirx = -1f;
        }
        else if (Wizard.transform.position.x == -8.5f)
        {
            chWizardDirx = 1f;
        }
        if (Wizard.transform.position.y == 3.5f)
        {
            chWizardDiry = -1f;
        }
        else if (Wizard.transform.position.y == -2.5f)
        {
            chWizardDiry = 1f;
        }

        for (int k = 0; k < 9; k++)
        {
            detectPos[k] = Wizard.transform.position;
            detectPos[k].x += 2f;
            detectPos[k].y += 1f;
        }

        for(int k = 0; k < 3; k++)
        {
            for(int j = 0; j < 3; j++)
            {
                detectPos[k].x += k;
                detectPos[j].y += j;
            }
        }

        changePos.x += chWizardDirx;
        changePos.y += chWizardDiry;

        for (int t = 0; t < Skeleton.Length; t++)
        {
            for (int k = 0; k < 9; k++)
            {
                if (Skeleton[t].transform.position == detectPos[k])
                {
                    return;
                }
            }
        }

        Wizard.transform.position = changePos;

    }

    IEnumerator defUpdate()
    {
        yield return new WaitForSeconds(0.3f);
        detectEnemy();
    }
}
