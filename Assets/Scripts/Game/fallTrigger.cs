using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class fallTrigger : MonoBehaviour {
    public GameObject ball;   //声明球需在unity中 赋

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (constofmenus.GAME_INDEX >= 17)
            {
                startsound.Instance.playmfall();
            }
            else
            {
                startsound.Instance.playfall();
            }
            Destroy(ball);
            Invoke("jump", 1);  //延时1s，跳转
        }
        
    }

    void jump()         //页面跳转
    {
        SceneManager.LoadScene(constofmenus.GAME_INDEX);
    } 
}
