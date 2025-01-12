using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat_Controller : MonoBehaviour
{
    float x_force = 0f;
    float y_force = 0f;

    //サウンド系
    //[SerializeField] AudioSource audioSource;
    void Start()
    {
        
        //Componentを取得
        //audioSource = GetComponent<AudioSource>();
        //rigidbody.sharedMaterialを取得
        var material = GetComponent<Rigidbody2D>().sharedMaterial;
        //rigidbodyを取得
        var rb = GetComponent<Rigidbody2D>();

        //マテリアル・リキッドボディ初期設定
        material.friction = 0;
        material.bounciness = 1;
        rb.gravityScale = 0;

        x_force = Random.Range(-6,6);
        y_force = Random.Range(-6,6);

        Vector2 force = new Vector2(x_force,y_force);    //力を設定
        
        rb.AddForce(force,ForceMode2D.Impulse);     //力を与える
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click ()    //クリックされたときの処理
    {
        //音を鳴らす
        //audioSource.Play();
        Destroy(gameObject);
        
    }
}
