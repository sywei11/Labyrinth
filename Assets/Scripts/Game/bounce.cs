using UnityEngine;
using System.Collections;

public class bounce : MonoBehaviour {
    public GameObject boun;   //弹力球
    public Transform shootPoint; //发射坐标
    public float CD;  //设置冷却时间

    private Animation Run;      //播放发射动画

    void Start()
    {
        Run = GetComponent<Animation>();
        InvokeRepeating("shoot", 0, CD);
    }

    void shoot()
    {
        GameObject newboun = Instantiate(boun, shootPoint.position, shootPoint.rotation) as GameObject;
        Rigidbody r = newboun.GetComponent<Rigidbody>();
        Run.Play();     //发射动画
        r.velocity = shootPoint.right * 1;      //给定速度方向位炮指向位置
    }
}
