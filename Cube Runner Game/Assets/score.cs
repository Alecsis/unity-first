using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public Transform player;
    public Text scoreTex;
    // Update is called once per frame
    void Update()
    {
        scoreTex.text = player.position.z.ToString("0");
    }
}
