using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using System.ComponentModel.Design;
using UnityEngine.SceneManagement;
using System;
using UnityEditor;
using unityroom.Api;



public class TimerChanger : MonoBehaviour
{
    public TextMeshProUGUI current_score_object; // Textオブジェク
    public TextMeshProUGUI max_score_object; // Textオブジェク

    public static float Maxscore = 999999;

     // 初期化
     void Start () 
     {
        float score = TextManager.ClearTime;

        //小数点2桁までで四捨五入
        score = Mathf.Round(score * 100f) / 100f;
        Maxscore = Mathf.Round(Maxscore * 100f) / 100f;
        
        //最速タイムの更新
        if(score < Maxscore)
        {
            Maxscore = score;
            // ボードNo1にスコア123.45fを送信する。
            UnityroomApiClient.Instance.SendScore(1, Maxscore, ScoreboardWriteMode.Always);
        }
        //表示
        current_score_object.text = "SCORE:" + score.ToString() + "s";
        max_score_object.text = "MAX     :" + Maxscore.ToString() + "s";


     }

     // 更新
     void Update ()
    {

    }
}
