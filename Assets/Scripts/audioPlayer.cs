using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlayer : MonoBehaviour
{
    public AudioClip sound1; //鳴らすSE
    AudioSource audioSource;

    int nowObjectsuu;
    
    // Start is called before the first frame update
    void Start()
    {
        //コンポーネントを取得
        audioSource = GetComponent<AudioSource>();
        nowObjectsuu = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }

    // Update is called once per frame
    void Update()
    {
        //Enemyの数が減っていたら音をならす
        if(GameObject.FindGameObjectsWithTag("Enemy").Length != nowObjectsuu)
        {
            //SEを鳴らす
            audioSource.PlayOneShot(sound1);
        }
        //現在のEnemyの数を取得
        nowObjectsuu = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }
}
