using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gamemenu : MonoBehaviour {
    public GameObject[] cameras;        //摄像机列表
    public Texture backgroundofgm;        //背景
    public GUIStyle[] buttonstyleofgm;    //各关卡按钮样式
    public GUIStyle[] buttonstyleofgm1;    //返回按钮
    //public static int curCam = 0;       //当前摄像机编号
	// Use this for initialization
	void Start () {
	
	}

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundofgm);  //绘制背景图片
        //绘制关卡按钮
        if (GUI.Button(new Rect(8 * Screen.width / 100, 15 * Screen.height / 100, 15 * Screen.width / 100, 25 * Screen.height / 100), "", buttonstyleofgm[0]))
        {
            startsound.Instance.playtouch();
            SceneManager.LoadScene(1);  //第一关
        }
        if (GUI.Button(new Rect(31 * Screen.width / 100, 15 * Screen.height / 100, 15 * Screen.width / 100, 25 * Screen.height / 100), "", buttonstyleofgm[1]))
        {
            startsound.Instance.playtouch();
            SceneManager.LoadScene(2);  
        }
        if (GUI.Button(new Rect(54 * Screen.width / 100, 15 * Screen.height / 100, 15 * Screen.width / 100, 25 * Screen.height / 100), "", buttonstyleofgm[2]))
        {
            startsound.Instance.playtouch();
            SceneManager.LoadScene(3);
        }
        if (GUI.Button(new Rect(77 * Screen.width / 100, 15 * Screen.height / 100, 15 * Screen.width / 100, 25 * Screen.height / 100), "", buttonstyleofgm[3]))
        {
            startsound.Instance.playtouch();
            SceneManager.LoadScene(4);
        }
        if (GUI.Button(new Rect(8 * Screen.width / 100, 55 * Screen.height / 100, 15 * Screen.width / 100, 25 * Screen.height / 100), "", buttonstyleofgm[4]))
        {
            startsound.Instance.playtouch();
            SceneManager.LoadScene(5);  
        }
        if (GUI.Button(new Rect(31 * Screen.width / 100, 55 * Screen.height / 100, 15 * Screen.width / 100, 25 * Screen.height / 100), "", buttonstyleofgm[5]))
        {
            startsound.Instance.playtouch();
            SceneManager.LoadScene(6);
        }
        if (GUI.Button(new Rect(54 * Screen.width / 100, 55 * Screen.height / 100, 15 * Screen.width / 100, 25 * Screen.height / 100), "", buttonstyleofgm[6]))
        {
            startsound.Instance.playtouch();
            SceneManager.LoadScene(7);
        }
        if (GUI.Button(new Rect(77 * Screen.width / 100, 55 * Screen.height / 100, 15 * Screen.width / 100, 25 * Screen.height / 100), "", buttonstyleofgm[7]))
        {
            startsound.Instance.playtouch();
            SceneManager.LoadScene(8);
        }
        if (GUI.Button(new Rect(85 * Screen.width / 100, 90 * Screen.height / 100, 15 * Screen.width / 100, 10 * Screen.height / 100), "", buttonstyleofgm[8]))
        {
            startsound.Instance.playback();
            ChangeCam(1);   //切换摄像机
        }
        if (GUI.Button(new Rect(38 * Screen.width / 100, 0 * Screen.height / 100, 24 * Screen.width / 100, 10 * Screen.height / 100), "", buttonstyleofgm[9]))
        {
            //界面标题
        }
        //返回按钮
        if (GUI.Button(new Rect(91 * Screen.width / 100, 0 * Screen.height / 100, 9 * Screen.width / 100, 16 * Screen.height / 100), "", buttonstyleofgm1[0]))
        {
            startsound.Instance.playback();
            SceneManager.LoadScene("main");
        }
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            startsound.Instance.playback();
            SceneManager.LoadScene("main");
        }
	}

    void ChangeCam(int Index)       //切换摄像机方法
    {
        cameras[0].SetActive(false);
        cameras[Index].SetActive(true);
    }
}
