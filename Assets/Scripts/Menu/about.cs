using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class about : MonoBehaviour {
    public Texture backgroudofsettings;
    public GUIStyle[] buttonstyleofsettings;        //设置按钮样式

	// Use this for initialization
	void Start () {
	
	}

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroudofsettings);  //绘制背景图片
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
            startsound.Instance.playback();
            SceneManager.LoadScene("main");
        }
	}
}
