using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * @file Teacher.cs
 * @brief 教師を操作するファイル
 * @author Kodai Nakata
 */

/**
 * @class Teacher
 * @brief 教師のクラス
 */
public class Teacher : MonoBehaviour
{
    //! 教師のアニメーター
    private Animator teacherAnim;
    //! タイマーの区間
    private float timeSpan;
    //! カウント用のタイマー
    private float timeCount;
    //! プレイヤーのアニメーター
    private Animator studentAnim;

    /**
     * @brief 最初のフレームに入る前に呼び出される関数
     */
    void Start()
    {
        teacherAnim = this.gameObject.GetComponent<Animator>();
        timeSpan = 1f;
        timeCount = 0f;
        studentAnim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
    }

    /**
     * @brief 1フレーム呼び出される関数
     */
    void Update()
    {
        Action();
    }

    /**
     * @brief 行動をする
     */
    private void Action()
    {

        // 学生が食べていることに気付いたとき
        if (DoNoticeEating())
        {
            teacherAnim.SetBool("IsAngry", true);// 怒りのアニメーションへ遷移
        }

        else
        {
            timeCount += Time.deltaTime;

            // タイマーが一定期間を超えたとき
            if (timeSpan < timeCount)
            {
                // 振り向きを実行するとき
                if (DoTurn())
                {
                    bool isTurnedStudent = teacherAnim.GetBool("IsTurnedStudent");// 教師がどの方向を向いているのか取得

                    // 学生の方向を向いているとき
                    if (isTurnedStudent)
                    {
                        teacherAnim.SetBool("IsTurnedStudent", false);// 黒板の方向へ振り向くアニメーションへ遷移
                    }
                    // 黒板の方向を向いているとき
                    else
                    {
                        teacherAnim.SetBool("IsTurnedStudent", true);// 学生の方向へ振り向くアニメーションへ遷移
                    }
                }
                timeCount = 0f;
            }
        }
    }

    /**
     * @brief 振り向くか
     * @return true:振り向く、false:振り向かない
     */
    private bool DoTurn()
    {
        int random = Random.Range(0, 4);// 1/4の確率で振り向くかを決める
        if(random == 0)
        {
            return true;
        }
        return false;
    }

    /**
     * @brief 学生が食べていることに気づいたか
     * @return true:気づいた、false:気づかない
     */
    private bool DoNoticeEating()
    {
        // 教師が学生の方向に向いているとき
        if (teacherAnim.GetCurrentAnimatorClipInfo(0)[0].clip.name == "Teacher_Student")
        {
            //facingRight = true;
            // 学生が食べているとき
            if (studentAnim.GetCurrentAnimatorClipInfo(0)[0].clip.name == "Student_Eat")
            {
                return true;
            }
        }
        return false;
    }
}
