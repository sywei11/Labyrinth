using UnityEngine;
using System.Collections;

public class cannon : MonoBehaviour {
    public GameObject bullet;   //子弹
    public float shootSpeed;    //射击速度
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
            GameObject newbullet =Instantiate(bullet, shootPoint.position, shootPoint.rotation) as GameObject;
            Rigidbody r = newbullet.GetComponent<Rigidbody>();
            Run.Play();             //发射的动画
            r.AddForce(shootPoint.right * shootSpeed, ForceMode.Impulse);        
    }

}