using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/**
* @file SESlider.cs
* @brief SEのスライダーを操作するクラス
* @author Kodai Nakata
*/

/**
 * @class SESlider
 * @brief SEのスライダー用のクラス
 */
public class SESlider : MonoBehaviour
{
    //! スライダー
    Slider slider;

    /**
     * @brief 最初のフレームに入る前に呼び出される関数
     */
    void Start()
    {
        slider = GetComponent<Slider>();
        SoundManager.Instance().SetSeVolume(slider.value);
    }

    /**
     * @brief 値の変更通知
     */
    public void OnValueChanged()
    {
        SoundManager.Instance().SetSeVolume(slider.value);
    }
}
