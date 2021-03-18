using UnityEngine;
using System.Collections;

public class blueTrigger_20 : MonoBehaviour {
    public Transform point1;       //门的一个位置
    public Transform point2;       //门的另一个位置
    public Transform door;        //门
    public float delayTime; //设置延时时间
    private int i = 0;      //用来判断开关
    private Animation Run;
    void Start()
    {
        Run = GetComponent<Animation>();       
    }

    void FixedUpdate()
    {
        if (i == 1)
        {
            door.transform.position = Vector3.MoveTowards(door.transform.position, point2.transform.position, Time.deltaTime);   //门移动
        }
        else
        {
            door.transform.position = Vector3.MoveTowards(door.transform.position, point1.transform.position, Time.deltaTime);   //门移动
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            i = 1;
            startsound.Instance.playtTri();
            Run.Play("blueTri0");
            Invoke("delay", delayTime); //delayTime后，执行delay
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Run.Play("blueTri1");
        }
    }

    int delay() //延时，改变i值
    {
        return i = 0;   //门移动回原位置
    }
}