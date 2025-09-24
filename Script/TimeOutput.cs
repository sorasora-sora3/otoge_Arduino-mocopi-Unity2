using System.Collections;
using System.Collections.Generic;
// using System.Diagnostics;
using System.IO;
using UnityEngine;

public class TimeOutput : MonoBehaviour
{
    private float elapsedTimeF = 0f;
    private float elapsedTimeG = 0f;
    private float elapsedTimeH = 0f;
    private float elapsedTimeJ = 0f;

    private string csvFilePath = "Assets/Output/times.csv";

    void Start()
    {
        // ヘッダを書き込む
        WriteToCSV("Key,ElapsedTime [s],CalculationResult");

        // 経過時間の初期値も書き込む（0秒の場合の計算結果）
        LogToCSV("Initial", 0f, CalculateResult(0f));
    }

    void Update()
    {
        // 経過時間を更新
        elapsedTimeF += Time.deltaTime;
        elapsedTimeG += Time.deltaTime;
        elapsedTimeH += Time.deltaTime;
        elapsedTimeJ += Time.deltaTime;

        // Fキーが押されたとき
        if (Input.GetKeyDown(KeyCode.F))
        {
            LogToCSV("pink", elapsedTimeF, CalculateResult(elapsedTimeF));
        }

        // Gキーが押されたとき
        if (Input.GetKeyDown(KeyCode.G))
        {
            LogToCSV("green", elapsedTimeG, CalculateResult(elapsedTimeG));
        }

        // Hキーが押されたとき
        if (Input.GetKeyDown(KeyCode.H))
        {
            LogToCSV("blue", elapsedTimeH, CalculateResult(elapsedTimeH));
        }

        // Jキーが押されたとき
        if (Input.GetKeyDown(KeyCode.J))
        {
            LogToCSV("orange", elapsedTimeJ, CalculateResult(elapsedTimeJ));
        }
    }

    void LogToCSV(string key, float time, float result)
    {
        // ファイルに書き込む
        WriteToCSV($"{key},{time},{result}");
    }

    void WriteToCSV(string line)
    {
        using (StreamWriter sw = File.AppendText(csvFilePath))
        {
            sw.WriteLine(line);
        }
    }

    float CalculateResult(float time)
    {
        // 9.9981 * 経過時間 + 5.4709 の計算結果
        return 9.9981f * time + 5.4709f;
    }




    /*private float elapsedTime = 0f;

    void Update()
    {
        // 経過時間を更新
        elapsedTime += Time.deltaTime;

        // Fキーが押されたとき
        if (Input.GetKeyDown(KeyCode.F))
        {
            UnityEngine.Debug.Log($"F {elapsedTime}");
        }

        // Gキーが押されたとき
        if (Input.GetKeyDown(KeyCode.G))
        {
            UnityEngine.Debug.Log($"G {elapsedTime}");
        }

        // Hキーが押されたとき
        if (Input.GetKeyDown(KeyCode.H))
        {
            UnityEngine.Debug.Log($"H {elapsedTime}");
        }

        // Jキーが押されたとき
        if (Input.GetKeyDown(KeyCode.J))
        {
            UnityEngine.Debug.Log($"J {elapsedTime}");
        }
    }*/
}
