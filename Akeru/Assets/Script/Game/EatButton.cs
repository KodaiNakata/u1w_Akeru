using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * @file EatButton.cs
 * @brief 食べるボタンを操作するファイル
 * @author Kodai Nakata
 */

/**
 * @class EatButton
 * @brief 食べるボタン用のクラス
 */
public class EatButton : MonoBehaviour
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
        playerAnim.SetBool("Eat", true);// 食べるアニメーションへ遷移
    }
}
