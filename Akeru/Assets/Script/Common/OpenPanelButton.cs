using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/**
* @file OpenPanelButton.cs
* @brief パネルを開くボタンを操作するファイル
* @author Kodai Nakata
*/

/**
 * @class OpenPanelButton
 * @brief パネルを開くボタン用のクラス
 */
public class OpenPanelButton : MonoBehaviour
{
    //! パネルを開くためのオブジェクト
    private GameObject openPanelObj;

    /**
     * @brief 最初のフレームに入る前に呼び出される関数
     */
    void Start()
    {
        openPanelObj = GameObject.FindGameObjectWithTag("PauseObject");
    }

    /**
     * @brief クリック通知
     */
    public void OnClick()
    {
        openPanelObj.transform.GetChild(0).gameObject.SetActive(true);
    }
}
