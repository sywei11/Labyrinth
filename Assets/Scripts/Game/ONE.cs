using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class ONE : MonoBehaviour
{
    public GUIStyle[] buttonstyleofONE;    //主界面按钮图样式
    // Use this for initialization
    void Start()
    {
        constofmenus.GAME_INDEX = SceneManager.GetActiveScene().buildIndex;  //获取当前页面索引，并存在GAME_INDEX中
    }

    void OnGUI()
    {
        //返回按钮
        if (GUI.Button(new Rect(91 * Screen.width / 100, 0 * Screen.height / 100, 9 * Screen.width / 100, 16 * Screen.height / 100), "", buttonstyleofONE[0]))
        {
            startsound.Instance.playtouch();
            SceneManager.LoadScene("gameover");
        }
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))       //按下返回键
        {
            startsound.Instance.playback();
            SceneManager.LoadScene("gameover");
        }

    }
}
