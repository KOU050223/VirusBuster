using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class huh_catPrefabGenerator : MonoBehaviour
{
    public GameObject huh_catPrefab;
    
    public static int cat_num = 10; //ネコの生成数

    void Start()
    {
        //宣言したcat_numの数だけランダムな場所に生成する
        for(int i=0;i < cat_num;i++)
        {
            GameObject go = Instantiate(huh_catPrefab);
            float x = Random.Range(-8,9);
            float y = Random.Range(-5,6);
            go.transform.position = new Vector3(x,y,0f);

        }
    }

    void Update()
    {
        /***
        deltaがスパンを超えたらランダムな場所に出現させる
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(huh_catPrefab);
            float x = Random.Range(-8,9);
            float y = Random.Range(-5,6);
            go.transform.position = new Vector3(x,y,0f);
        }
        ***/
        
    }
    
}
