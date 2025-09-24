using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Title : MonoBehaviour

{
    private new AudioSource audio;
    [SerializeField]
    private AudioClip sound;
    public SerialReceiver serialReceiverComponent;


    // Start is called before the first frame update

    public void Start()

    {
        audio = gameObject.AddComponent<AudioSource>();
        GameObject serialUtilObject = GameObject.Find("SerialUtil");
        serialReceiverComponent = serialUtilObject.GetComponent<SerialReceiver>();
        //ボタンが押された時、StartGame関数を実行する

        //gameObject.GetComponent<Button>().onClick.AddListener(StartGame);

        /*if(serialReceiverComponent.touchvalue != 0)
        {
            StartGame();
        }*/

    }

    // Update is called once per frame

    void StartGame()

    {

        //GameSceneをロードする

        SceneManager.LoadScene("GameScene");

    }

    void Update()
    {
        UnityEngine.Debug.Log(serialReceiverComponent.touchvalue);

        if (serialReceiverComponent.touchvalue != 0)
        {
            audio.PlayOneShot(sound);
            Invoke("StartGame", 2.0f);
            // StartGame();
        }
    }

}