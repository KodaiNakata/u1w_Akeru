using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/**
* @file SoundButton.cs
* @brief サウンドボタンを操作するファイル
* @author Kodai Nakata
*/

/**
 * @class SoundButton
 * @brief サウンドのボタン用のクラス
 */
public class SoundButton : MonoBehaviour
{
    //! サウンド用の設定のオブジェクト
    private GameObject soundConfig;

    /**
     * @brief 最初のフレームに入る前に呼び出される関数
     */
    void Start()
    {
        soundConfig = GameObject.FindGameObjectWithTag("SoundConfig");
    }

    /**
     * @brief クリック通知
     */
    public void OnClick()
    {
        soundConfig.transform.GetChild(0).gameObject.SetActive(true);
    }
}
