using UnityEngine;
using System.Collections;

public class backandforth : MonoBehaviour {
    private int i = 0;      //用来判断方向
    
    public float bfSpeed;       //设置小块往返的速度

	// Update is called once per frame
	void FixedUpdate () {
        if (i == 1)
        {
            transform.Translate(Vector3.right * Time.deltaTime * bfSpeed);  
        }
        else
        {
            transform.Translate( -1 * Vector3.right * Time.deltaTime * bfSpeed);
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            i++;
            i = i % 2;
        }
    }

}
