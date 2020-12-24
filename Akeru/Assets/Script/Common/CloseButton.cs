using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
* @file CloseButton.cs
* @brief 閉じるボタンを操作するファイル
* @author Kodai Nakata
*/

/**
 * @class CloseButton
 * @brief 閉じるのボタン用のクラス
 */
public class CloseButton : MonoBehaviour
{
    /**
     * @brief クリック通知
     */
    public void OnClick()
    {
        transform.parent.gameObject.SetActive(false);
    }
}
