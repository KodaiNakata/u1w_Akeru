using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
/**
 * @file GameDirector.cs
 * @brief ゲームの監督用ファイル
 * @author Kodai Nakata
 */

/**
 * @class GameDirector
 * @brief ゲームの監督用のクラス
 */
public class GameDirector : MonoBehaviour
{
    //! 教師のアニメーター
    Animator teacherAnim;
    //! 学生のアニメーター
    Animator playerAnim;
    //! スコア
    private int score;
    //! スコア表示用のテキスト
    private TextMeshProUGUI scoreText;
    //! 学生のアニメーションの以前の正規化時間
    private float beforePlayerAnimNormalizedTime;

    /**
     * @brief 最初のフレームに入る前に呼び出される関数
     */
    void Start()
    {
        teacherAnim = GameObject.FindGameObjectWithTag("Teacher").GetComponent<Animator>();
        playerAnim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        score = 0;
        scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<TextMeshProUGUI>();
        UpdateScoreText();
        beforePlayerAnimNormalizedTime = 0f;
        ResultManager.Instance().SetScore(0);
    }

    /**
     * @brief 1フレーム呼び出される関数
     */
    void Update()
    {
        // 教師が怒っているアニメーションをしているとき
        if (teacherAnim.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.Teacher_Angry"))
        {
            // 最後までアニメーションが再生し終えたとき
            if (teacherAnim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1f)
            {
                SceneManager.LoadScene("ResultScene");// リザルト画面へ遷移
            }
        }
        else
        {
            // 学生が食べるアニメーションをしているとき
            if (playerAnim.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.Student_Eat"))
            {
                // 最後までアニメーションが再生し終えたとき
                if (playerAnim.GetCurrentAnimatorStateInfo(0).normalizedTime - beforePlayerAnimNormalizedTime >= 1f)
                {
                    // スコアの更新
                    beforePlayerAnimNormalizedTime = playerAnim.GetCurrentAnimatorStateInfo(0).normalizedTime;
                    score++;
                    ResultManager.Instance().SetScore(score);
                    UpdateScoreText();
                }
            }
            else
            {
                beforePlayerAnimNormalizedTime = 0f;
            }

            // スコアが最大に満たしたとき
            if (ResultManager.Instance().GetScore() >= ResultManager.MAX_SCORE)
            {
                SceneManager.LoadScene("ResultScene");// リザルト画面へ遷移
            }
        }
    }

    /**
     * @brief スコア表示用のテキストを更新
     */
    private void UpdateScoreText()
    {
        scoreText.text = "のこり\n" + (ResultManager.MAX_SCORE - score).ToString() + "g";
    }
}
