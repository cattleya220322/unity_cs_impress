using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    /// <summary>
    /// キャラクターの名前
    /// </summary>
    public string name_;

    /// <summary>
    /// キャラクターの経験値
    /// </summary>
    public int exp_;

    /// <summary>
    /// Constructor
    /// </summary>
    public Character()
    {
        name_ = "未設定";
    }

    /// <summary>
    /// Constructor (overload)
    /// </summary>
    /// <param name="name">キャラクターの名前設定</param>
    public Character(string name)
    {
        this.name_ = name;
    }
    /// <summary>
    /// ステータス表示
    /// </summary>
    public void PrintStatsInfo()
    {
        Debug.Log($"Hero: {name_} - {exp_} EXP");
    }
}
