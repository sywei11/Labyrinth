using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ballmove : MonoBehaviour {
    public float moveSpeed;     //小球移动速度

    private bool isDestroyed = false;
    private Rigidbody ball;

    //private Vector3 horMovement;
    //private Vector3 verMovement;

    private Vector3 dir = Vector3.zero;

    void Start()
    {
        ball = GetComponent<Rigidbody>();
    }

	// Update is called once per frame
    void FixedUpdate()
    {   //以下 为wasd 移动
        //x 轴   
        /*horMovement = Input.GetAxis("Horizontal") * Vector3.right * moveSpeed;
        //z 轴  
        verMovement = Input.GetAxis("Vertical") * Vector3.forward * moveSpeed;
        //小球的运动  
        Vector3 movement = horMovement + verMovement;

        //为小球施加力  
        ball.AddForce(movement, ForceMode.Force);*/
        
        //以下为重力感应
        dir.x = Input.acceleration.x;
        dir.z = Input.acceleration.y;
        ball.AddForce(dir * moveSpeed, ForceMode.Force);
}

    void OnCollisionEnter(Collision collision)
    {
        startsound.Instance.playcoll();     //碰撞音效
        if (collision.gameObject.tag == "bullet")       //如果撞到子弹，爆炸
        {
            isDestroyed = true;
            startsound.Instance.playBoom();     //播放爆炸音效
            Destroy(gameObject);
        }
    }

    void OnDestroy()
    {
        if (isDestroyed)
        {
            SceneManager.LoadScene(constofmenus.GAME_INDEX);   //小球被销毁后，返回原来所在关卡
        }
    }
}
