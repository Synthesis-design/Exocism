using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    Knight knightinfo;
    Archer archerinfo;
    Wizard wizardinfo;
    Hwang hwanginfo;
    Assassin assassininfo;
    King kinginfo;
    Skeleton Enemyinfo;
    GameObject detect;
    Vector3[] detectPos; //적 감지 위치
    Vector3 changePos; //이동 거리
    float chKnightDir = 1f;
    float chArcherDir = 1f;
    float chHwangDir = 1f;
    float chAssassinDir = 1f;
    float chWizardDirx = 1f;
    float chWizardDiry = 1f;
    float chSkelDir = -1f;
    int Jumpcnt = 0;

    Animator Assassinanim;
    Animator Knightanim;
    Animator Archeranim;
    Animator Wizardanim;
    Animator Hwanganim;
    Animator Kinganim;
    Animator Enemyanim;



    void Start()
    {
        detectEnemy();
        Assassinanim = GameObject.FindGameObjectWithTag("Assassin").GetComponent<Animator>();
        //Knightanim = GameObject.FindGameObjectWithTag("Knight").GetComponent<Animator>();
        Archeranim = GameObject.FindGameObjectWithTag("Archer").GetComponent<Animator>();
        //Wizardanim = GameObject.FindGameObjectWithTag("Wizard").GetComponent<Animator>();
        

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

        if (King != null)
        {
            for(int i = 0; i < King.Length; i++)
            {
                KingAtk(King[i], Skeleton);
            }
        }

        for(int i = 0; i < Skeleton.Length; i++)
        {
            SkeletonMove(Skeleton[i], Knight, Assassin,Archer, Wizard, King, Hwang);
        }

        
        

        StartCoroutine(defUpdate());
    }

    void KnightMove(GameObject Knight, GameObject[] Skeleton)
    {
        knightinfo = Knight.GetComponent<Knight>();
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
                    KnightAtk(Knight, Skeleton[t], knightinfo, Enemyinfo);
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
                    HwnagAtk(Hwang, Knight[t]);
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
                    HwnagAtk(Hwang, Assassin[t]);
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
                    HwnagAtk(Hwang, Archer[t]);
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
                    HwnagAtk(Hwang, oHwang[t]);
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
                    HwnagAtk(Hwang, Wizard[t]);
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
                    HwnagAtk(Hwang, King[t]);
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
                    ArcherAtk(Archer, Skeleton[j], archerinfo, Enemyinfo);
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
                        Jumpcnt++;
                        AssassinAtk(Assassin, Skeleton[t], assassininfo, Enemyinfo, Jumpcnt);
                        return;
                    }
                    AssassinAtk(Assassin, Skeleton[t], assassininfo, Enemyinfo, Jumpcnt);
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


        for (int j = 0; j < 9; j++)
        {
            detectPos[j].x += j % 3;
            detectPos[j].y -= j / 3;
        }
        

        changePos.x += chWizardDirx;
        changePos.y += chWizardDiry;

        for (int i = 0; i < Skeleton.Length; i++)
        {
            for (int k = 0; k < 9; k++)
            {
                if (Skeleton[i].transform.position == detectPos[k])
                {
                    changePos = Wizard.transform.position;
                    WizardAtk(Wizard, Skeleton[i], wizardinfo, Enemyinfo);
                    if (k==9)
                    {
                        return;
                    }
                }
            }
        }

        Wizard.transform.position = changePos;

    }

    void KnightAtk(GameObject Knight, GameObject Skeleton, Knight info, Skeleton Enemyinfo)
    {
        info = Knight.GetComponent<Knight>();
        Enemyinfo = Skeleton.GetComponent<Skeleton>();

        Enemyinfo.hp -= info.atk;

        Debug.Log("때림");
        Knightanim = Knight.GetComponent<Animator>();
        Knightanim.SetTrigger("atk");
        if (Enemyinfo.hp <= 0)
        {
            Destroy(Skeleton);
        }
        Knightanim.SetTrigger("idle");

    }

    void ArcherAtk(GameObject Archer, GameObject Skeleton, Archer info, Skeleton Enemyinfo)
    {
        info = Archer.GetComponent<Archer>();
        Enemyinfo = Skeleton.GetComponent<Skeleton>();

        Enemyinfo.hp -= info.atk;
        Archeranim = Archer.GetComponent<Animator>();
        Archeranim.SetTrigger("atk");
        if (Enemyinfo.hp <= 0)
        {
            Destroy(Skeleton);
        }
        Archeranim.SetTrigger("idle");
    }

    void AssassinAtk(GameObject Assassin, GameObject Skeleton, Assassin info, Skeleton Enemyinfo, int cnt)
    {
        
        info = Assassin.GetComponent<Assassin>();
        Enemyinfo = Skeleton.GetComponent<Skeleton>();

        if(cnt == 1)
        {
            Assassin.transform.position = Skeleton.transform.position;
            info.atk = 3;
        }
        else
        {
            info.atk = 1;
        }
        
        Enemyinfo.hp -= info.atk;
        Assassinanim.SetTrigger("atk");
        if (Enemyinfo.hp <= 0)
        {
            Destroy(Skeleton);
        }
        Assassinanim.SetTrigger("idle");
       
        
    }

    void WizardAtk(GameObject Wizard, GameObject Skeleton, Wizard info, Skeleton Enemyinfo)
    {
        info = Wizard.GetComponent<Wizard>();
        Enemyinfo = Skeleton.GetComponent<Skeleton>();

        Enemyinfo.hp -= info.atk;

        Wizardanim = Wizard.GetComponent<Animator>();
        Wizardanim.SetTrigger("atk");
        if (Enemyinfo.hp <= 0)
        {
            Destroy(Skeleton);
        }
        Wizardanim.SetTrigger("idle");
        

    }


    void KingAtk(GameObject King, GameObject[] Skeleton)
    {
        int cnt = 0;
        kinginfo = King.GetComponent<King>();
        Kinganim = GameObject.FindGameObjectWithTag("King").GetComponent<Animator>();

        for (int i = 0; i < Skeleton.Length; i++)
        {
            Enemyinfo = Skeleton[i].GetComponent<Skeleton>();
        }

        for(int i = 0; i < Skeleton.Length; i++)
        {
            if (cnt % 2 == 0)
            {
                Enemyinfo.hp -= kinginfo.atk;
                
                Kinganim.SetTrigger("atk");
            }
            else if(cnt%2!=0)
            {
                return;
            }

            if (Enemyinfo.hp <= 0)
            {
                Destroy(Skeleton[i]);
            }
            cnt++;
        }
        Kinganim.SetTrigger("idle");

    }

    void SkeletonMove(GameObject Skeleton, GameObject[] knight, GameObject[] assassin, GameObject[] archer, GameObject[] wizard, GameObject[] king, GameObject[] hwang)
    {
        Enemyinfo = Skeleton.GetComponent<Skeleton>();
        changePos = Skeleton.transform.position;

        if (Skeleton.transform.position.x == 8.5f)
        {

            chSkelDir = -1f;
        }
        else if (Skeleton.transform.position.x == -8.5f)
        {
            chSkelDir = 1f;
        }

        for (int k = 0; k < 2; k++)
        {
            detectPos[k] = Skeleton.transform.position;
        }

        detectPos[0].x -= 1f;
        detectPos[1].x -= 1f;
        detectPos[2].x -= 1f;
        detectPos[0].y += 1f;
        detectPos[2].y -= 1f;
        detectPos[3].x += 1f;

        changePos.x += chSkelDir;

        for (int t = 0; t < knight.Length; t++)
        {
            for (int k = 0; k < 4; k++)
            {
                if (knight[t].transform.position == detectPos[k])
                {
                    SkeletonAtk(Skeleton, knight[t], knightinfo,archerinfo, assassininfo, wizardinfo, hwanginfo, kinginfo, Enemyinfo);
                    return;
                }
            }
        }

        for (int t = 0; t < archer.Length; t++)
        {
            for (int k = 0; k < 4; k++)
            {
                if (archer[t].transform.position == detectPos[k])
                {
                    SkeletonAtk(Skeleton, archer[t], knightinfo,archerinfo, assassininfo, wizardinfo, hwanginfo, kinginfo, Enemyinfo);
                    return;
                }
            }
        }

        for (int t = 0; t < wizard.Length; t++)
        {
            for (int k = 0; k < 4; k++)
            {
                if (wizard[t].transform.position == detectPos[k])
                {
                    SkeletonAtk(Skeleton, wizard[t], knightinfo, archerinfo, assassininfo, wizardinfo, hwanginfo, kinginfo, Enemyinfo);
                    return;
                }
            }
        }

        for (int t = 0; t < assassin.Length; t++)
        {
            for (int k = 0; k < 4; k++)
            {
                if (assassin[t].transform.position == detectPos[k])
                {
                    SkeletonAtk(Skeleton, assassin[t], knightinfo, archerinfo, assassininfo, wizardinfo, hwanginfo, kinginfo, Enemyinfo);
                    return;
                }
            }
        }

        for (int t = 0; t < king.Length; t++)
        {
            for (int k = 0; k < 4; k++)
            {
                if (king[t].transform.position == detectPos[k])
                {
                    SkeletonAtk(Skeleton, king[t], knightinfo, archerinfo, assassininfo, wizardinfo, hwanginfo, kinginfo, Enemyinfo);
                    return;
                }
            }
        }

        for (int t = 0; t < hwang.Length; t++)
        {
            for (int k = 0; k < 4; k++)
            {
                if (hwang[t].transform.position == detectPos[k])
                {
                    SkeletonAtk(Skeleton, hwang[t], knightinfo, archerinfo, assassininfo, wizardinfo, hwanginfo, kinginfo, Enemyinfo);
                    return;
                }
            }
        }

        Skeleton.transform.position = changePos;

    }

    void HwnagAtk(GameObject Hwang, GameObject player)
    {
        hwanginfo = Hwang.GetComponent<Hwang>();
        Hwanganim = GameObject.FindGameObjectWithTag("Hwang").GetComponent<Animator>();
        Hwanganim.SetTrigger("Hill");
        if (player.name == "knight")
        {
            knightinfo = player.GetComponent<Knight>();
            knightinfo.atk += hwanginfo.atk;
        }
        if (player.name == "Archer")
        {
            archerinfo = player.GetComponent<Archer>();
            archerinfo.atk += hwanginfo.atk;
        }
        if (player.name == "Assassin")
        {
            assassininfo = player.GetComponent<Assassin>();
            assassininfo.atk += hwanginfo.atk;

        }
        if (player.name == "Hwang")
        {
            hwanginfo = player.GetComponent<Hwang>();
            hwanginfo.atk += hwanginfo.atk;

        }
        if (player.name == "Wizard")
        {
            wizardinfo = player.GetComponent<Wizard>();
            wizardinfo.atk += hwanginfo.atk;
        }
        if (player.name == "King")
        {
            kinginfo = player.GetComponent<King>();
            kinginfo.atk += hwanginfo.atk;
        }
        Hwanganim.SetTrigger("idle");
    }

    void SkeletonAtk(GameObject Skeleton, GameObject player, Knight knightinfo, Archer archerinfo, Assassin assassininfo, Wizard wizardinfo, Hwang hwanginfo, King kinginfo, Skeleton Enemyinfo)
    {
        Enemyinfo = Skeleton.GetComponent<Skeleton>();
        Debug.Log(player.name);
        if (player.name == "knight")
        {
            knightinfo = player.GetComponent<Knight>();
            knightinfo.hp -= Enemyinfo.atk;
            if (knightinfo.hp <= 0)
            {
                Destroy(player);
            }
        }
        if (player.name == "Archer")
        {
            archerinfo = player.GetComponent<Archer>();
            archerinfo.hp -= Enemyinfo.atk;
            if (archerinfo.hp <= 0)
            {
                Destroy(player);
            }
        }
        if (player.name == "Assassin")
        {
            assassininfo = player.GetComponent<Assassin>();
            assassininfo.hp -= Enemyinfo.atk;
            if (assassininfo.hp <= 0)
            {
                Destroy(player);
            }
        }
        if (player.name == "Hwang")
        {
            hwanginfo = player.GetComponent<Hwang>();
            hwanginfo.hp -= Enemyinfo.atk;
            if (hwanginfo.hp <= 0)
            {
                Destroy(player);
            }

        }
        if (player.name == "Wizard")
        {
            wizardinfo = player.GetComponent<Wizard>();
            wizardinfo.hp -= Enemyinfo.atk;
            if (wizardinfo.hp <= 0)
            {
                Destroy(player);
            }
        }
        if (player.name == "King")
        {
            kinginfo = player.GetComponent<King>();
            kinginfo.hp -= Enemyinfo.atk;
            if (kinginfo.hp <= 0)
            {
                Destroy(player);
            }
        }
        Enemyanim = GameObject.FindGameObjectWithTag("skeleton").GetComponent<Animator>();
        Enemyanim.SetTrigger("atk");

    }

    IEnumerator defUpdate()
    {
        yield return new WaitForSeconds(1f);
        detectEnemy();

    }
}
