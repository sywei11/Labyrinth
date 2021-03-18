using UnityEngine;
using System.Collections;

public class greenTrigger : MonoBehaviour {
    private int i;
    private Animation Run;
    private GameObject [] bullet;   //声明炮弹数组

	// Use this for initialization
	void Start () {
        Run = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        bullet = GameObject.FindGameObjectsWithTag("bullet");//获取炮弹
        if (i == 1)
        {
            for(int k=0;k < bullet.Length;k++){
                Destroy(bullet[k]); //销毁
            }
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            i = 1;
            startsound.Instance.playTri();
            Run.Play("greenTri0");
            Invoke("redo", 4);      //4秒钟后重新发射
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Run.Play("greenTri1");
        }
    }

    int redo()
    {
        return i = 0;
    }
}
