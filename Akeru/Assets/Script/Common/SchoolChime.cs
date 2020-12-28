using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * @file SchoolChime.cs
 * @brief 学校のチャイム用ファイル
 * @author Kodai Nakata
 */

/**
 * @class SchoolChime
 * @brief 学校のチャイム用のクラス
 */
public class SchoolChime : MonoBehaviour
{
    /**
     * @brief 最初のフレームに入る前に呼び出される関数
     */
    void Start()
    {
        AudioSource chimeSource = GetComponent<AudioSource>();
        chimeSource.volume = SoundManager.Instance().GetBgmVolume();
        chimeSource.PlayOneShot(chimeSource.clip);
    }
}
