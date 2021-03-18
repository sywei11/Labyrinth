using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class main : MonoBehaviour {
    public Texture backgroundofmain;        //主界面背景
    public GUIStyle[] buttonstyleofmain;    //主界面按钮图样式

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundofmain);  //绘制背景图片
        //绘制开始按钮
        if (GUI.Button(new Rect(35 * Screen.width / 100, 40 * Screen.height / 100, 30 * Screen.width / 100, 25 * Screen.height / 100), "", buttonstyleofmain[0]))
        {
            startsound.Instance.playtouch();
            SceneManager.LoadScene("gamemenu");
            Destroy(this);
        }
        //绘制设置按钮
        if (GUI.Button(new Rect(90 * Screen.width / 100, 75 * Screen.height / 100, 10 * Screen.width / 100, 10 * Screen.height / 100), "", buttonstyleofmain[1]))
        {
            startsound.Instance.playtouch();
            SceneManager.LoadScene("settings");
            Destroy(this);
        }
        //绘制关于按钮
        if (GUI.Button(new Rect(90 * Screen.width / 100, 90 * Screen.height / 100, 10 * Screen.width / 100, 10 * Screen.height / 100), "", buttonstyleofmain[2]))
        {
            startsound.Instance.playtouch();
            SceneManager.LoadScene("about");
            Destroy(this);
        }
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))       //按下返回键
        {
            startsound.Instance.playback();
            Application.Quit();             //游戏退出
        }
	}
}
