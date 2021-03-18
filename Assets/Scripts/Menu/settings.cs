using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class settings : MonoBehaviour {
    public Texture backgroudofsettings;
    public Texture2D[] musicBtns;       //背景音乐按钮数组
    public Texture2D[] soundBtns;      //音效按钮数组
    private int musicIndex;             //音乐索引
    private int soundIndex;            //音效索引
    public GUIStyle btStyle;            //按钮样式
    public GUIStyle[] buttonstyleofsettings;        //设置界面返回按钮样式
	// Use this for initialization
	void Awake () {
        soundIndex = PlayerPrefs.GetInt("offsound");      //初始化音效索引
        musicIndex = PlayerPrefs.GetInt("offmusic");        //初始化音乐索引
	}

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroudofsettings);  //绘制背景图片
        //音乐按钮
        if (GUI.Button(new Rect(63 * Screen.width / 100, 39 * Screen.height / 100, 10 * Screen.width / 100, 10 * Screen.height / 100), musicBtns[musicIndex%2], btStyle))
        {
            musicIndex++;       //按钮索引加一
            PlayerPrefs.SetInt("offmusic", musicIndex % 2);     //新的索引存入
            playmusic(PlayerPrefs.GetInt("offmusic"));
            startsound.Instance.playtouch();
        }
        //音效按钮
        if (GUI.Button(new Rect(63 * Screen.width / 100, 55 * Screen.height / 100, 10 * Screen.width / 100, 10 * Screen.height / 100), soundBtns[soundIndex % 2], btStyle))
        {
            soundIndex++;       //按钮索引加一
            PlayerPrefs.SetInt("offsound", soundIndex % 2);     //新的索引存入
            startsound.Instance.playtouch();
        }
        //返回按钮
        if (GUI.Button(new Rect(91 * Screen.width / 100, 0 * Screen.height / 100, 9 * Screen.width / 100, 16 * Screen.height / 100), "", buttonstyleofsettings[0]))
        {
            startsound.Instance.playback();
            SceneManager.LoadScene("main");
        }
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("main");
        }
	}

    void playmusic(int i)       //修改设置后播放音乐，设置立即能看出来效果
    {
        if (i == 0)
        {

            startmusic.Instance.Music.Play();
        }
        else
        {
            startmusic.Instance.Music.Pause();
        }
    }
}
