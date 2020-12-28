using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/**
 * @file QuitButton.cs
 * @brief やめるボタンを操作するファイル
 * @author Kodai Nakata
 */

/**
 * @class QuitButton
 * @brief やめるボタン用のクラス
 */
public class QuitButton : MonoBehaviour
{
    /**
     * @brief クリック通知
     */
    public void OnClick()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartScene");// スタート画面へ遷移
    }
}
