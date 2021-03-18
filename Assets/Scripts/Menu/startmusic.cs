using UnityEngine;
using System.Collections;

public class startmusic : MonoBehaviour {
    public AudioSource Music;       //声明声音对象
    public static startmusic Instance;  //指向自己
    void Awake () {
        Instance = this;
        Music = GetComponent<AudioSource>();
     	if(PlayerPrefs.GetInt("offmusic") == 0)     //背景音乐索引值
     	{
            Music.Play();       //播放背景音乐
      	}
	}
	
	// Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("offmusic") != 0)
        {
            Music.Stop();       //背景音乐停止
        }
        var cameras = GameObject.FindGameObjectsWithTag("main");
        if (cameras.Length > 1)
        {
            GameObject.Destroy(cameras[0]);     //防止背景音乐重复播放
        }
    }

}
