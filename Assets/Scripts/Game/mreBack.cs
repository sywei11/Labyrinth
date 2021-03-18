using UnityEngine;
using System.Collections;

public class mreBack : MonoBehaviour {
    public int Force;   //自定义给多大的力

    private Animation mBigger;
    private GameObject ball;
    private Rigidbody b;

    // Use this for initialization
    void Start()
    {
        mBigger = GetComponent<Animation>();
        ball = GameObject.FindGameObjectWithTag("Player");
        b = ball.GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        startsound.Instance.playreback();
        mBigger.Play();
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == ball)
        {
            Vector3 direction = b.velocity.normalized;
            b.AddForce(direction * Force, ForceMode.Impulse);
        }
    }
}
