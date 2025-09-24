using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using System.Diagnostics;

public class NotesBreaking : MonoBehaviour
{
    /*private JoyconManager joyconManager;
    private List<Joycon> joycons;
    private Joycon joyconL;
    private Joycon joyconR;*/

    


    // from Collisionmusic
    private new AudioSource audio;
    [SerializeField]
    private AudioClip sound;
    public SerialReceiver serialReceiverComponent;

    // from ScoreSm
    Vector3 posi;
    // public SerialReceiver serialReceiverComponent;
    public Scoretext Sm1;

    // from ComboSm
    public Combotext Sm2;

    // from ScoregaugeManager
    public Slider scoregauge;

    //---------------------------------------------------//
    //---------------------------------------------------//
    //---------------------------------------------------//
    //---------------------------------------------------//
    //---------------------------------------------------//
    //---------------------------------------------------//
    void Start()
    {
        



        /*joyconManager = GameObject.FindObjectOfType<JoyconManager>();

        if (joyconManager == null)
        {
            UnityEngine.Debug.LogError("JoyconManagerが見つかんねぇんだわ。探せ！この世のすべてをそこに置いてきた！");
            return;
        }
        joycons = joyconManager.j; // JoyconManagerからJoyconのリストを取得

        joyconL = joycons.Find(c => c.isLeft); // Joy-Con (L)
        joyconR = joycons.Find(c => !c.isLeft); // Joy-Con (R)*/

        // from Collisionmusic
        audio = gameObject.AddComponent<AudioSource>();
        GameObject serialUtilObject = GameObject.Find("SerialUtil");
        serialReceiverComponent = serialUtilObject.GetComponent<SerialReceiver>();

        // from ScoreSm
        // GameObject serialUtilObject = GameObject.Find("SerialUtil");
        // serialReceiverComponent = serialUtilObject.GetComponent<SerialReceiver>();
        Sm1 = GameObject.Find("scorecounttext").GetComponent<Scoretext>();

        // from ComboSm
        Sm2 = GameObject.Find("combocounttext").GetComponent<Combotext>();

        // from ScoregaugeManager
        scoregauge = GameObject.Find("scoregauge").GetComponent<Slider>();
        scoregauge.value = 0;

    }
    //---------------------------------------------------//
    //---------------------------------------------------//
    //---------------------------------------------------//        
    //---------------------------------------------------//
    //---------------------------------------------------//
    //---------------------------------------------------//




    //---------------------------------------------------//
    //---------------------------------------------------//
    //---------------------------------------------------//        
    //---------------------------------------------------//
    //---------------------------------------------------//
    //---------------------------------------------------//
    void Update()
    {
        
        posi = this.transform.position;
        //UnityEngine.Debug.Log(serialReceiverComponent.touchvalue);

        //---------------------------------------------------//
        //---------------------------------------------------//
        //---------------------------------------------------//
        if (serialReceiverComponent.touchvalue == 2
            && this.gameObject.tag == "pink")
        {
            audio.PlayOneShot(sound);
            UnityEngine.Debug.Log(serialReceiverComponent.touchvalue);
            if (posi.z >= 4.6 && posi.z <= 5.6)
            {
                Sm1.Score += 20;
                Sm2.Combo += 1;
                scoregauge.value += 0.008f;
                this.gameObject.SetActive(false);
            }
            else if (posi.z > 5.6 && posi.z <= 6.6)
            {
                Sm1.Score += 10;
                Sm2.Combo += 1;
                scoregauge.value += 0.004f;
                this.gameObject.SetActive(false);
            }
        }
        //---------------------------------------------------//
        //---------------------------------------------------//
        //---------------------------------------------------//
        else if (serialReceiverComponent.touchvalue == 3
            && this.gameObject.tag == "green")
        {
            audio.PlayOneShot(sound);
            UnityEngine.Debug.Log(serialReceiverComponent.touchvalue);
            if (posi.z >= 4.6 && posi.z <= 5.6)
            {
                Sm1.Score += 20;
                Sm2.Combo += 1;
                scoregauge.value += 0.008f;
                this.gameObject.SetActive(false);
            }
            else if (posi.z > 5.6 && posi.z <= 6.6)
            {
                Sm1.Score += 10;
                Sm2.Combo += 1;
                scoregauge.value += 0.004f;
                this.gameObject.SetActive(false);
            }
        }
        //---------------------------------------------------//
        //---------------------------------------------------//
        //---------------------------------------------------//
        else if (serialReceiverComponent.touchvalue == 4
            && this.gameObject.tag == "blue")
        {
            audio.PlayOneShot(sound);
            UnityEngine.Debug.Log(serialReceiverComponent.touchvalue);
            if (posi.z >= 4.6 && posi.z <= 5.6)
            {
                Sm1.Score += 20;
                Sm2.Combo += 1;
                scoregauge.value += 0.008f;
                this.gameObject.SetActive(false);
            }
            else if (posi.z > 5.6 && posi.z <= 6.6)
            {
                Sm1.Score += 10;
                Sm2.Combo += 1;
                scoregauge.value += 0.004f;
                this.gameObject.SetActive(false);
            }
        }
        //---------------------------------------------------//
        //---------------------------------------------------//
        //---------------------------------------------------//
        else if (serialReceiverComponent.touchvalue == 5
            && this.gameObject.tag == "orange")
        {
            audio.PlayOneShot(sound);
            UnityEngine.Debug.Log(serialReceiverComponent.touchvalue);
            if (posi.z >= 4.6 && posi.z <= 5.6)
            {
                Sm1.Score += 20;
                Sm2.Combo += 1;
                scoregauge.value += 0.008f;
                this.gameObject.SetActive(false);
            }
            else if (posi.z > 5.6 && posi.z <= 6.6)
            {
                Sm1.Score += 10;
                Sm2.Combo += 1;
                scoregauge.value += 0.004f;
                this.gameObject.SetActive(false);
            }
        }
    }
}
