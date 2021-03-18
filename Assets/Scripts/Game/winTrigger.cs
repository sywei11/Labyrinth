using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class winTrigger : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")    //触发的物体是小球
        {
            startsound.Instance.playwin();  //胜利音效
            constofmenus.GAME_INDEX = SceneManager.GetActiveScene().buildIndex;  //获取当前页面索引，并存在GAME_INDEX中
            SceneManager.LoadScene("gamevictory");  //跳转时游戏胜利界面
        }
    }
}
