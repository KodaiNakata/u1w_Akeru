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
    Slider slider;

    /**
     * @brief 最初のフレームに入る前に呼び出される関数
     */
    void Start()
    {
        slider = GetComponent<Slider>();
        SoundManager.Instance().SetBgmVolume(slider.value);
    }

    /**
     * @brief 値の変更通知
     */
    public void OnValueChanged()
    {
        SoundManager.Instance().SetBgmVolume(slider.value);
    }
}
