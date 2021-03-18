using UnityEngine;
using System.Collections;

public class greenTrigger_19 : MonoBehaviour {
    public Transform point1_1;       //门的一个位置
    public Transform point1_2;       //门的另一个位置
    public Transform door;        //门

    public Transform point2_1;
    public Transform point2_2;
    public Transform door1;

    private Animation Run;      //声明动画
    private int i;      //

    // Use this for initialization
    void Start()
    {
        Run = GetComponent<Animation>();       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (i == 1)
        {
            door.transform.position = Vector3.MoveTowards(door.transform.position, point1_2.transform.position, Time.deltaTime);   //门移动
            door1.transform.position = Vector3.MoveTowards(door1.transform.position, point2_2.transform.position, Time.deltaTime);   //门移动
        }
        else
        {
            door.transform.position = Vector3.MoveTowards(door.transform.position, point1_1.transform.position, Time.deltaTime);   //门移动
            door1.transform.position = Vector3.MoveTowards(door1.transform.position, point2_1.transform.position, Time.deltaTime);   //门移动
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && i == 0)
        {
            i = 1;
            startsound.Instance.playTri();
            Run.Play("greenTri0");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Run.Play("greenTri1");
        }
    }
}
