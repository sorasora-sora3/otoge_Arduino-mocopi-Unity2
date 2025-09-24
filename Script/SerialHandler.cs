using UnityEngine;
using System.Collections;
using System.IO.Ports;
using System.Threading;
//using System.Diagnostics;

public class SerialHandler : MonoBehaviour
{
    public delegate void SerialDataReceivedEventHandler(string message);
    public event SerialDataReceivedEventHandler OnDataReceived;
    //ポート名
    //windows では COM1 など
    //Mac では/dev/tty.usbmodem1421 など
    public string portName = "COM4";
    public int baudRate; //ArduinoでのSerial.begin()の引数と絶対同じにする！！！
    private SerialPort serialPort_;
    private Thread thread_;
    private bool isRunning_ = false;
    private string message_;
    private bool isNewMessageReceived_ = false;
    void Awake()
    {
        Open();
    }
    void Update()
    {
        if (isNewMessageReceived_)
        {
            OnDataReceived(message_);
        }
        isNewMessageReceived_ = false;
    }
    void OnDestroy()
    {
        Close();
    }
    private void Open()
    {
        serialPort_ = new SerialPort(portName, baudRate, Parity.None, 8, StopBits.One);
        //または
        //serialPort_ = new SerialPort(portName, baudRate);
        serialPort_.Open();
        isRunning_ = true;
        thread_ = new Thread(Read);
        thread_.Start();
    }
    private void Close()
    {
        isNewMessageReceived_ = false;
        isRunning_ = false;
        if (thread_ != null && thread_.IsAlive)
        {
            thread_.Join();
        }
        if (serialPort_ != null && serialPort_.IsOpen)
        {
            serialPort_.Close();
            serialPort_.Dispose();
        }
    }
    private void Read()
    {
        while (isRunning_ && serialPort_ != null && serialPort_.IsOpen)
        {
            try
            {
                message_ = serialPort_.ReadLine();
                isNewMessageReceived_ = true;
            }
            catch (System.Exception e)
            {
                UnityEngine.Debug.LogWarning(e.Message);
            }
        }
    }
    public void Write(string message)
    {
        try
        {
            serialPort_.Write(message);
        }
        catch (System.Exception e)
        {
            UnityEngine.Debug.LogWarning(e.Message);
        }
    }
}