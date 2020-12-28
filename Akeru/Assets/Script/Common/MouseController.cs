using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
/**
 * @file MouseController.cs
 * @brief マウス操作のファイル
 * @author Kodai Nakata
 */

/**
 * @class MouseController
 * @brief マウス操作のクラス
 */
public class MouseController : MonoBehaviour
{
    //! ポインタ（マウス/タッチ）イベントに関連するイベントの情報
    private PointerEventData pointer;

    /**
     * @brief 最初のフレームに入る前に呼び出される関数
     */
    void Start()
    {
        pointer = new PointerEventData(EventSystem.current);
    }

    /**
     * @brief 1フレーム呼び出される関数
     */
    void Update()
    {
        // 左クリックしたとき
        if (Input.GetMouseButtonDown(0))
        {
            // スタート画面でクリックされたとき
            if (SceneManager.GetActiveScene().name == "StartScene")
            {
                List<RaycastResult> results = new List<RaycastResult>();
                // マウスポインタの位置にレイ飛ばし、ヒットしたものを保存
                pointer.position = Input.mousePosition;
                EventSystem.current.RaycastAll(pointer, results);

                foreach (RaycastResult target in results)
                {
                    // 音量調整ボタンをクリックまたはポーズパネルが表示されているとき
                    if(target.gameObject.name == "SoundButton" )
                    {
                        return;// 遷移しない
                    }
                }

                GameObject pausePanel = GameObject.FindGameObjectWithTag("PauseObject").transform.GetChild(0).gameObject;
                // ポーズのパネルが表示状態の時
                if (pausePanel.activeSelf)
                {
                    return;// 遷移しない
                }
                SceneManager.LoadScene("GameScene");
            }
            // リザルト画面でクリックしたとき
            else if (SceneManager.GetActiveScene().name == "ResultScene")
            {
                SceneManager.LoadScene("StartScene");
            }
        }
    }
}
