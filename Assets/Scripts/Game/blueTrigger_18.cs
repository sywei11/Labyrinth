using UnityEngine;
using System.Collections;

public class blueTrigger_18 : MonoBehaviour {
    public static int Index;        //设置触发索引

    public Transform point1;       //门的一个位置
    public Transform point2;       //门的另一个位置
    public Transform door;        //门

    private Animation Run;      //声明动画
    private int i;      //

    // Use this for initialization
	void Start () {
        Run = GetComponent<Animation>();
        Index = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (blueTrigger_18.Index == 4)
        {
            door.transform.position = Vector3.MoveTowards(door.transform.position, point2.transform.position, Time.deltaTime);   //门移动;
        }
        else
        {
            door.transform.position = Vector3.MoveTowards(door.transform.position, point1.transform.position, Time.deltaTime);   //门移动
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && i==0)
        {
            i = 1;
            blueTrigger_18.Index++;
            startsound.Instance.playtTri();
            Run.Play();
        }
    }
}
