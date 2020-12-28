using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * @file NotEatButton.cs
 * @brief 食べないボタンを操作するファイル
 * @author Kodai Nakata
 */

/**
 * @class NotEatButton
 * @brief 食べないボタン用のクラス
 */
public class NotEatButton : MonoBehaviour
{
    //! プレイヤーのオブジェクト
    private GameObject playerObj;

    //! プレイヤーのアニメーター
    private Animator playerAnim;

    /**
     * @brief 最初のフレームに入る前に呼び出される関数
     */
    void Start()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");
        playerAnim = playerObj.GetComponent<Animator>();
    }

    /**
     * @brief クリック通知
     */
    public void OnClick()
    {
        playerAnim.SetBool("Eat", false);// 食べないアニメーションへ遷移
    }
}
