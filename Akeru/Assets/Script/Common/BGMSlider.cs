using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/**
 * @file BGMSlider.cs
 * @brief BGMのスライダーを操作するクラス
 * @author Kodai Nakata
 */

/**
 * @class BGMSlider
 * @brief BGMのスライダー用のクラス
 */
public class BGMSlider : MonoBehaviour
{
    //! スライダー
    private Slider slider;
    //! 学校のチャイムの音源
    private AudioSource chimeSource;

    /**
     * @brief 最初のフレームに入る前に呼び出される関数
     */
    void Start()
    {
        InitSliderValue();

        GameObject chimeObj = GameObject.FindGameObjectWithTag("Chime");
        if (chimeObj != null)
        {
            chimeSource = chimeObj.GetComponent<AudioSource>();
        }
    }

    /**
     * @brief オブジェクトが有効時の関数
     */
    void Awake()
    {
        InitSliderValue();
        
        GameObject chimeObj = GameObject.FindGameObjectWithTag("Chime");
        if (chimeObj != null)
        {
            chimeSource = chimeObj.GetComponent<AudioSource>();
        }
    }

    /**
     * @brief 値の変更通知
     */
    public void OnValueChanged()
    {
        SoundManager.Instance().SetBgmVolume(slider.value);
        if (chimeSource != null)
        {
            chimeSource.volume = slider.value;
        }
    }

    /**
     * @brief スライダーの値の初期化
     */
    private void InitSliderValue()
    {
        slider = GetComponent<Slider>();
        slider.value = SoundManager.Instance().GetBgmVolume();
        SoundManager.Instance().SetBgmVolume(slider.value);
    }
}
