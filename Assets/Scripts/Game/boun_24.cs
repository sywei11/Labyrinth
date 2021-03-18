using UnityEngine;
using System.Collections;

public class boun_24 : MonoBehaviour {
    public int collTime;  //设置小球碰撞几次，然后自毁
    public float speed;       //设置弹力球移动快慢

    private int i;      //碰撞次数
    private Rigidbody b;

    // Use this for initialization
    void Awake()
    {
        b = GetComponent<Rigidbody>();
        blueTrigger_speed.speed = speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        speed = blueTrigger_speed.speed;
        b.velocity = b.velocity.normalized;
        b.AddForce(b.velocity * speed, ForceMode.Force);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Plane")
        {
            i++;
        }
        if (i >= (collTime + 1))      //有两次在炮内就撞了
        {
            Destroy(this.gameObject);
        }
    }
}
