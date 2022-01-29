using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Weapon;

public class ArrowSeletor : MonoBehaviour
{
    [SerializeField] public GameObject goldArrowSelect;
    [SerializeField] public GameObject greenArrowSelect;
    [SerializeField] public GameObject purpleArrowSelect;
    [SerializeField] public GameObject goldArrowNumber;
    [SerializeField] public GameObject greenArrowNumber;
    [SerializeField] public GameObject purpleArrowNumber;
    [SerializeField] public Quiver quiver;

    private List<String> ArrowType = new List<string>();

    public GameObject currentArrow;
    public void Awake()
    {
        currentArrow = goldArrowSelect;
        ArrowType.Add(goldArrowSelect.name);
        ArrowType.Add(greenArrowSelect.name);
        ArrowType.Add(purpleArrowSelect.name);
    }

    public String GetCurrentArrow()
    {
        return currentArrow.name;
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

        ChangeCount();
    }

    public void ChangeCount()
    {
        //Text goldArrow = goldArrowNumber.GetComponent<Text>();
        //goldArrow.text = quiver.GetArrowCount(goldArrowNumber.name).ToString();

        //Text purpleArrow = purpleArrowSelect.GetComponent<Text>();
        //purpleArrow.text = quiver.GetArrowCount(purpleArrowSelect.name).ToString();
        
        //Text greenArrow = greenArrowSelect.GetComponent<Text>();
        //greenArrow.text = quiver.GetArrowCount(greenArrowSelect.name).ToString();
    }

    public List<String> GetArrowType()
    {
        return ArrowType;
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
