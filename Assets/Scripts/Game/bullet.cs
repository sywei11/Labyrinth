using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {
    public int collTime;  //设置子弹碰撞几次，然后自毁 ， 在炮内就有两次，出来装一次就没了
    private int i;      //碰撞次数

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Plane")       //产生碰撞的不是地面
        {
            i++;
        }
        if (i >= (collTime+2))         //够次数了
        {
            Destroy(this.gameObject);
        }
        if ( collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

}
