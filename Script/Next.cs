using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{
    [SerializeField] int openTime = 204;

    // Start is called before the first frame update
    void Start()
    {
        //オブジェクトを非アクティブにする
        this.gameObject.SetActive(false);
        //204秒後にOpen関数を実行する
        Invoke("Open", openTime);
    }

    //
    void Open()
    {
        //オブジェクトをアクティブにする
        this.gameObject.SetActive(true);
    }
}