using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
* @file ClosePanelButton.cs
* @brief パネルを閉じるボタンを操作するファイル
* @author Kodai Nakata
*/

/**
 * @class ClosePanelButton
 * @brief パネルを閉じるのボタン用のクラス
 */
public class ClosePanelButton : MonoBehaviour
{
    /**
     * @brief クリック通知
     */
    public void OnClick()
    {
        transform.parent.gameObject.SetActive(false);
    }
}
