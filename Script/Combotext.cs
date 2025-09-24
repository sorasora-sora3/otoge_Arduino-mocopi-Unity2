using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Combotext : MonoBehaviour
{
    //コンボ加算したいtextと紐付ける
    public float Combo;
    public TextMeshProUGUI combocounttext;

    //Combotextにアクセスして実行する
    internal static void SetCombotext()
    {
        throw new NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        //0からスタートする
        Combo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //textのフォーマットを設定する
        combocounttext.text = string.Format("{0}", Combo);
    }
}