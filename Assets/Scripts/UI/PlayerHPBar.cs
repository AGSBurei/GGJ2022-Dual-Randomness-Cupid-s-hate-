using System;
using System.Collections;
using System.Collections.Generic;
using Platformer.Mechanics;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPBar : MonoBehaviour
{
    public Slider slider;
    
    [SerializeField] 
    public GameObject player;

    public CharacterStats playerStat;

    public void Start()
    {
        playerStat = player.GetComponent<CharacterStats>();
    }

    public void LateUpdate()
    {
        setMaxHP(playerStat.HP);
        setHPBar(playerStat.currentHP);
    }

    public void setMaxHP(int hp)
    {
        slider.maxValue = hp;
        slider.value = hp;
    }

    public void setHPBar(int hp)
    {
        slider.value = hp;
    }
}
