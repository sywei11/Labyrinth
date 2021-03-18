using UnityEngine;
using System.Collections;

public class breback : MonoBehaviour {
    public int Force;   //自定义给多大的力

    private Animation bBigger;
    private GameObject ball;
    private Rigidbody b;

    // Use this for initialization
    void Start()
    {
        bBigger = GetComponent<Animation>();
        ball = GameObject.FindGameObjectWithTag("Player");
        b = ball.GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        startsound.Instance.playreback();
        bBigger.Play();
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
