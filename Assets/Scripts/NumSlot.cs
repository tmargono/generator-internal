using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class NumSlot : MonoBehaviour
{
    char[] numbersRand = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    public Text slotNum;
    public float time;
    public int num;
    public GameObject playButton;

    // Update is called once per frame
    void Update()
    {
        slotNum.text = numbersRand[UnityEngine.Random.Range(0, numbersRand.Length)].ToString();
    }

    public void OffEnable()
    {
        Invoke("DelayNum", time);
    }

    public void OffEnableRig()
    {
        Invoke("DelayNumRig", time);
    }

    //Enable this script
    public void OnEnable()
    {
        enabled = true;
    }

    //Stop Update Function from running, disable script
    void DelayNum()
    {
        enabled = false;
        if (num == 4)
        {
            playButton.SetActive(true);
        }
    }

    //Rig to all 7
    void DelayNumRig()
    {
        slotNum.text = 7.ToString();
        enabled = false;
        if (num == 4)
        {
           playButton.SetActive(true);
        }
        
    }
}
