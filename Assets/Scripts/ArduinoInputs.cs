using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ArduinoInputs : MonoBehaviour
{
    //Setting the serial port that the arduino will communicate through
    SerialPort sp = new SerialPort("COM3", 9600);
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;
    }

    // Reading in teh information from the Arduino
    void Update()
    {
        speed = float.Parse(sp.ReadLine());
        GameObject.FindObjectOfType<PlayerMovement>().speedInput = speed;
        Debug.Log("speed arduino: " + speed);
    }
}
