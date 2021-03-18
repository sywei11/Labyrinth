using UnityEngine;
using System.Collections;

public class sreBack : MonoBehaviour {
    public int Force;   //自定义给多大的力

    private Animation sBigger;
    private GameObject ball;
    private Rigidbody b;

    // Use this for initialization
    void Start()
    {
        sBigger = GetComponent<Animation>();
        ball = GameObject.FindGameObjectWithTag("Player");  //捕捉到小球
        b = ball.GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        startsound.Instance.playreback();
        sBigger.Play();     //播放动画
    }

    void OnCollisionExit(Collision collision)   //碰撞物离开时操作
    {
        if (collision.gameObject == ball)
        {
            Vector3 direction = b.velocity.normalized;
            b.AddForce(direction * Force, ForceMode.Impulse);
        }
    }
}
