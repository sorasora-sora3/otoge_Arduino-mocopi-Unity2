using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

public class SerialReceiver : MonoBehaviour
{
    //https://qiita.com/yjiro0403/items/54e9518b5624c0030531
    //上記 URL の SerialHandler.c のクラス
    public SerialHandler serialHandler;
    public int touchvalue;

    void Start()
    {
        //信号を受信したときに、そのメッセージの処理を行う
        serialHandler.OnDataReceived += OnDataReceived;
    }

    //受信した信号(message)に対する処理
    void OnDataReceived(string message)
    {
        var data = message.Split(new string[] { "\t" }, System.StringSplitOptions.None);
        
        try
        {
            int.TryParse(data[0], out touchvalue);
            //受信したデータを整数値に変換し touchvalue に格納
            //UnityEngine.Debug.Log(touchvalue);
            //UnityEngine.Debug.Log("Received touchvalue: " + touchvalue);
        }

        catch (System.Exception e)
        {
            UnityEngine.Debug.LogWarning(e.Message);//エラーを表示
        }
    }
}