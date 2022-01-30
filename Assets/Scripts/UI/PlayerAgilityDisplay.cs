using System;
using System.Collections;
using System.Collections.Generic;
using Platformer.Mechanics;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAgilityDisplay : MonoBehaviour
{
    [SerializeField] 
    private GameObject agilityValue;
    
    [SerializeField] 
    public GameObject player;

    public CharacterStats playerStat;

    public void Start()
    {
        playerStat = player.GetComponent<CharacterStats>();
    }

    public void LateUpdate()
    {
        SetAGIDisplay(playerStat.AGI);
    }

    public void SetAGIDisplay(int agi)
    {
        Text value = agilityValue.GetComponent<Text>();
        value.text = agi.ToString();
    }
}