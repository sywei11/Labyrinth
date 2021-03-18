using UnityEngine;
using System.Collections;

public class blueTrigger_rotate : MonoBehaviour {
    public int Circle;        //设置几次为一循环
    public int angle;        //设置每次旋转角度
    public Transform bounce;

    private int i = 0;      //Trigger 计数
    private Animation Run;

    void Start()
    {
        Run = GetComponent<Animation>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            i++;
            i = i % Circle;
            if (i == 0)
            {
                bounce.Rotate(Vector3.up * (Circle-1) * angle);
                startsound.Instance.playtTri();
            }
            else
            {
                bounce.Rotate(Vector3.down * angle);
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