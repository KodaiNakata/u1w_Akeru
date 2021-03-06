﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * @file SoundManager.cs
 * @brief サウンドの管理スクリプトのファイル
 * @author Kodai Nakata
 */

/**
 * @class SoundManager
 * @brief サウンドの管理用のクラス
 */
public class SoundManager
{
    //! BGMの音量
    private float bgmVolume = 0.2f;

    //! 自クラスのインスタンス 
    private static SoundManager instance;

    /**
     * @brief 自クラスのインスタンスを取得する
     * @return インスタンス
     */
    public static SoundManager Instance()
    {
        if(instance == null)
        {
            instance = new SoundManager();
        }
        return instance;
    }

    /**
     * @brief BGMの音量のゲッター
     * @return BGMの音量
     */
    public float GetBgmVolume()
    {
        return bgmVolume;
    }

    /**
     * @brief BGMの音量のセッター
     * @param[out] volume 音量
     */
    public void SetBgmVolume(float volume)
    {
        bgmVolume = volume;
    }
}
