using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * @file ResultManager.cs
 * @brief リザルト管理用ファイル
 * @author Kodai Nakata
 */

/**
 * @class ResultManager
 * @brief リザルト管理用のクラス
 */
public class ResultManager
{
    //! 最大スコア
    public const int MAX_SCORE = 60;
    //! 自クラスのインスタンス
    private static ResultManager instance;
    //! スコア
    private int score;

    /**
     * @brief 自クラスのインスタンスを取得する
     * @return インスタンス
     */
    public static ResultManager Instance()
    {
        if(instance == null)
        {
            instance = new ResultManager();
        }
        return instance;
    }

    /**
     * @brief スコアを取得する
     * @return スコア
     */
    public int GetScore()
    {
        return score;
    }

    /**
     * @brief スコアをセットする
     * @param[out] スコア
     */
    public void SetScore(int score)
    {
        this.score = score;
    }

    /**
     * @brief 結果を出力する
     * @return スコアをもとにした結果
     */
    public string OutputResult()
    {
        if (score >= MAX_SCORE)
        {
            return "たべきった";
        }
        return "たべのこした " + "のこり" + (MAX_SCORE - score).ToString() + "g";
    }
}
