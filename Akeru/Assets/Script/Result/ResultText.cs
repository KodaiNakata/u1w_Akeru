using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
/**
 * @file ResultText.cs
 * @brief リザルトテキスト用ファイル
 * @author Kodai Nakata
 */

/**
 * @class ResultText
 * @brief リザルトテキスト用のクラス
 */
public class ResultText : MonoBehaviour
{
    /**
     * @brief 最初のフレームに入る前に呼び出される関数
     */
    void Start()
    {
        TextMeshProUGUI text = GetComponent<TextMeshProUGUI>();
        text.text = ResultManager.Instance().OutputResult();
    }
}
