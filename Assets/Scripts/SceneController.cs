using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;  //シーンの管理をしているクラス

public class SceneController : MonoBehaviour
{
    [SerializeField] string nextScene;   //次のシーンの名前をアタッチ

    public void SwitchScene()
    {
        SceneManager.LoadScene(nextScene,LoadSceneMode.Single);
    }

    public void Exit()
    {
        //UnityEditor.EditorApplication.isPlaying = false; //ゲームプレイ終了
    }

}
