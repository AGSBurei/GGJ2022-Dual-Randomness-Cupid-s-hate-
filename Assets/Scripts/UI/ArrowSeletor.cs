using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowSeletor : MonoBehaviour
{
    [SerializeField] 
    public GameObject goldArrowSelect;
    [SerializeField] 
    public GameObject greenArrowSelect;
    [SerializeField] 
    public GameObject purpleArrowSelect;

    public GameObject currentArrow;
    public void Awake()
    {
        currentArrow = goldArrowSelect;
    }

    public void LateUpdate()
    {
        if(Input.GetKeyUp(KeyCode.Alpha1))
        {
            currentArrow = goldArrowSelect;
        }
        
        if(Input.GetKeyUp(KeyCode.Alpha2))
        {
            currentArrow = purpleArrowSelect;
        }
        
        if(Input.GetKeyUp(KeyCode.Alpha3))
        {
            currentArrow = greenArrowSelect;
        }

        UpdateArrow();
    }
    
    private void UpdateArrow()
    {
        DisableAll();
        currentArrow.SetActive(true);
    }

    private void DisableAll()
    {
        goldArrowSelect.SetActive(false);
        greenArrowSelect.SetActive(false);
        purpleArrowSelect.SetActive(false);
    }
}
