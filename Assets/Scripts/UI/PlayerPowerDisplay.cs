using System;
using System.Collections;
using System.Collections.Generic;
using Platformer.Mechanics;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPowerDisplay : MonoBehaviour
{
    [SerializeField] 
    private GameObject powerValue;
    
    [SerializeField] 
    public GameObject player;

    public CharacterStats playerStat;

    public void Start()
    {
        playerStat = player.GetComponent<CharacterStats>();
    }

    public void LateUpdate()
    {
        SetSTRDisplay(playerStat.STR);
    }

    public void SetSTRDisplay(int str)
    {
        Text value = powerValue.GetComponent<Text>();
        value.text = str.ToString();
    }
}