using UnityEngine;
using System.Collections;

public class blueTrigger_speed : MonoBehaviour {
    public static float speed;     //设置速度

    public int Circle;        //设置几次为一循环

    private int i = 1;      //Trigger 计数
    private Animation Run;
    private float speed0;

    void Start()
    {
        Run = GetComponent<Animation>();
        speed0 = speed;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            i++;
            speed = speed0 * i;
            i = i % Circle;
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
