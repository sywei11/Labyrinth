using UnityEngine;
using System.Collections;

public class greenTrigger_24 : MonoBehaviour {
    public Transform point1;       //门的一个位置
    public Transform point2;       //门的另一个位置
    public Transform door;        //门

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
            i++;
            i = i % 2;
            startsound.Instance.playTri();
            Run.Play("greenTri0");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Run.Play("greenTri1");
        }
    }

}