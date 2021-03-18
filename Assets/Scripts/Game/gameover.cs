using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour {
    public Texture backgroundofover;        //背景
    public GUIStyle[] buttonstyleofover;    //各功能按钮
    public GUIStyle[] buttonstyleofover1;    //返回按钮

    private int i = constofmenus.GAME_INDEX;        //将存储的索引值给i

	
    // Use this for initialization
	void Start () {
	    
	}

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundofover);  //绘制背景图片
        //继续游戏
        if (GUI.Button(new Rect(35 * Screen.width / 100, 20 * Screen.height / 100, 30 * Screen.width / 100, 15 * Screen.height / 100), "", buttonstyleofover[0]))
        {
            startsound.Instance.playtouch();
            SceneManager.LoadScene(i);
        }
        //关卡选择
        if (GUI.Button(new Rect(35 * Screen.width / 100, 45 * Screen.height / 100, 30 * Screen.width / 100, 15 * Screen.height / 100), "", buttonstyleofover[1]))
        {
            startsound.Instance.playtouch();
            SceneManager.LoadScene("gamemenu");
        }
        //上一关
        if (i != 1)
        {
            if (GUI.Button(new Rect(10 * Screen.width / 100, 75 * Screen.height / 100, 18 * Screen.width / 100, 20 * Screen.height / 100), "", buttonstyleofover[2]))
            {
                startsound.Instance.playtouch();
                SceneManager.LoadScene(i-1);
            }
        }
        //下一关
        if (i != 24)
        {
            if (GUI.Button(new Rect(72 * Screen.width / 100, 75 * Screen.height / 100, 18 * Screen.width / 100, 20 * Screen.height / 100), "", buttonstyleofover[3]))
            {
                startsound.Instance.playtouch();
                SceneManager.LoadScene(i+1);
            }
        }
  
        //返回按钮
        if (GUI.Button(new Rect(91 * Screen.width / 100, 0 * Screen.height / 100, 9 * Screen.width / 100, 16 * Screen.height / 100), "", buttonstyleofover1[0]))
        {
            startsound.Instance.playtouch();
            SceneManager.LoadScene(i);
        }

    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))       //按下返回键
        {
            startsound.Instance.playback();
            //加一个回到原来位置
            SceneManager.LoadScene(i);            
        }
	}
}
