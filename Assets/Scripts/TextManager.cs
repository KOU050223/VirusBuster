using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TextManager : MonoBehaviour
{
    public TextMeshProUGUI score_object; // Textオブジェク

    public static float ClearTime;
    
    float delta = 0f;
    float span = 0.5f;

    GameObject[] tagObjects;

    // Start is called before the first frame update
    void Start()
    {
        score_object.text = huh_catPrefabGenerator.cat_num.ToString();
        ClearTime = 0;
    }

    void Update () {
        // オブジェクトからTextコンポーネントを取得
        //Text score_text = score_object.GetComponent<Text> ();
        delta += Time.deltaTime;
        if(delta > span)
        {
            delta = 0;
            // テキストの表示をエネミーの数に入れ替える
            score_object.text =Check("Enemy") +"";
        }

        //クリアタイムを加算する
        ClearTime += Time.deltaTime;
    }
    int Check(string tagname)
        {
            tagObjects = GameObject.FindGameObjectsWithTag(tagname);
            if (tagObjects.Length == 0)
            {
                SceneManager.LoadScene("Result");
            }
            return tagObjects.Length;
        }
}
