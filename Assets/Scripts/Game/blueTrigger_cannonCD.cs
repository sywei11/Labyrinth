using UnityEngine;
using System.Collections;

public class blueTrigger_cannonCD : MonoBehaviour {
    public static float cannonCD;     //cannonCD

    public int cannonCircle;        //设置几次为一循环

    private int i = 1;      //Trigger 计数
    private Animation Run;
    private float CD;

    void Start()
    {
        Run = GetComponent<Animation>();
        CD = cannonCD;         //最开始CD
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            i++;
            cannonCD = CD * i;
            i = i % cannonCircle;
            if (i == 0)
            {
                startsound.Instance.playtTri();
            }
            else
            {
                startsound.Instance.playTri();
            }
            Run.Play("blueTri0");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Run.Play("blueTri1");
        }
    }

}
