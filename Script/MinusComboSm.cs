using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusComboSm : MonoBehaviour
{
    //コンボやCombotextをアタッチしているcombocounttextを格納する
    public Combotext Sm;

    // Start is called before the first frame update
    void Start()
    {
        //コンポーネントからCombotextを検出する
        Sm = GameObject.Find("combocounttext").GetComponent<Combotext>();
    }

    //衝突した時
    private void OnCollisionEnter(Collision collision)
    {
        //コンボが0や"resetbox"タグのオブジェクトに衝突した場合
        if (collision.gameObject.tag == "resetbox")
        {
            //コンボを0にする
            Sm.Combo = 0;

            //オブジェクトが消える
            Destroy(this.gameObject);
        }
    }
}