using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class gamevictory : MonoBehaviour {

    public Texture backgroundofvic;        //背景
    public GUIStyle[] buttonstyleofvic;    //各功能按钮
    //public GUIStyle[] buttonstyleofvic1;    //返回按钮

    private int i = constofmenus.GAME_INDEX;        //将存储的索引值给i

    // Use this for initialization
    void Start()
    {

    }

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundofvic);  //绘制背景图片
        //再玩一次
        if (GUI.Button(new Rect(35 * Screen.width / 100, 20 * Screen.height / 100, 30 * Screen.width / 100, 15 * Screen.height / 100), "", buttonstyleofvic[0]))
        {
            startsound.Instance.playtouch();
            SceneManager.LoadScene(i);
        }
        //关卡选择
        if (GUI.Button(new Rect(35 * Screen.width / 100, 45 * Screen.height / 100, 30 * Screen.width / 100, 15 * Screen.height / 100), "", buttonstyleofvic[1]))
        {
            startsound.Instance.playtouch();
            SceneManager.LoadScene("gamemenu");
        }
        //上一关
        if (i != 1) {    //判断之前页面是否为第一关
            if (GUI.Button(new Rect(10 * Screen.width / 100, 75 * Screen.height / 100, 18 * Screen.width / 100, 20 * Screen.height / 100), "", buttonstyleofvic[2]))
            {
                startsound.Instance.playtouch();
                SceneManager.LoadScene(i-1);        //索引去前一关
            }
        }
        
        //下一关
        if (i != 24)     //判断之前页面是否为最后一关
        {
            if (GUI.Button(new Rect(72 * Screen.width / 100, 75 * Screen.height / 100, 18 * Screen.width / 100, 20 * Screen.height / 100), "", buttonstyleofvic[3]))
            {
                startsound.Instance.playtouch();
                SceneManager.LoadScene(i+1);        //索引去后一关
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))       //按下返回键
        {
            startsound.Instance.playback();
            //加一个回到原来位置
            SceneManager.LoadScene("gamemenu");
        }
	}
}
