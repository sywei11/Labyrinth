using UnityEngine;
using System.Collections;

public class startsound : MonoBehaviour {

    private AudioSource Sound;       //声明声音对象
    public static startsound Instance;     //

    public AudioClip touch;     //点击按钮音效
    public AudioClip back;      //返回按钮音效

    public AudioClip fall;      //小球掉落音效
    public AudioClip collision; //小球碰撞音效
    public AudioClip win;       //小球胜利音效

    public AudioClip metalfall;     //金属小球掉落
    public AudioClip metalcollsion;     //金属球碰撞音效
    public AudioClip reback;        //反弹柱体
    public AudioClip explosion;          //小球爆炸
    public AudioClip Tri;       //Trigger触发音效
    public AudioClip timeTri;   //次数Trigger触发

    // Use this for initialization
    void Awake()                //awake 播放更早
    {     
        Instance = this;
        Sound = GetComponent<AudioSource>();
    }

    public bool isSound()           //判断音效开关
    {
        if(PlayerPrefs.GetInt("offsound") == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void playtouch()
    {
        if (isSound())        //若音效索引为0
        {
            //Sound.clip = touch;
            Sound.PlayOneShot(touch);
        }
    }
    public void playback()
    {
        if (isSound())        //若音效索引为0
        {
            Sound.clip = back;
            Sound.Play();
        }
    }

    public void playfall()
    {
        if (isSound())        //若音效索引为0
        {
            Sound.clip = fall;
            Sound.Play();
        }
    }

    public void playcoll()
    {
        if (isSound())        //若音效索引为0
        {
            Sound.PlayOneShot(collision);
        }
    }

    public void playwin()
    {
        if (isSound())        //若音效索引为0
        {
            Sound.clip = win;
            Sound.Play();
        }
    }

    public void playmfall()
    {
        if (isSound())        
        {
            Sound.clip = metalfall;
            Sound.Play();
        }
    }

    public void playmcoll()
    {
        if (isSound())
        {
            Sound.clip = metalcollsion;
            Sound.Play();
        }
    }

    public void playreback()
    {
        if (isSound())
        {
            Sound.clip = reback;
            Sound.Play();
        }
    }

    public void playBoom()
    {
        if (isSound())
        {
            Sound.clip = explosion;
            Sound.Play();
        }
    }

    public void playTri()
    {
        if (isSound())
        {
            Sound.clip = Tri;
            Sound.Play();
        }
    }

    public void playtTri()
    {
        if (isSound())
        {
            Sound.clip = timeTri;
            Sound.Play();
        }
    }
}
