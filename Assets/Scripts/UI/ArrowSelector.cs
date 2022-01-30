using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Weapon;



    public class ArrowSelector : MonoBehaviour
    {
        [SerializeField] public GameObject goldArrowSelect;
        [SerializeField] public GameObject greenArrowSelect;
        [SerializeField] public GameObject purpleArrowSelect;
        [SerializeField] public GameObject goldArrowNumber;
        [SerializeField] public GameObject greenArrowNumber;
        [SerializeField] public GameObject purpleArrowNumber;
        [SerializeField] public Quiver quiver;

        private List<String> ArrowTypes = new List<string>();

        public GameObject currentArrow;
        public void Awake()
        {
            currentArrow = goldArrowSelect;
            ArrowTypes.Add(goldArrowSelect.name);
            ArrowTypes.Add(greenArrowSelect.name);
            ArrowTypes.Add(purpleArrowSelect.name);
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
            Text goldArrow = goldArrowNumber.GetComponent<Text>();
            Text greenArrow = greenArrowNumber.GetComponent<Text>();
            Text purpleArrow = purpleArrowNumber.GetComponent<Text>();

            goldArrow.text = quiver.GetArrowCount(goldArrowSelect.name).ToString();
            greenArrow.text = quiver.GetArrowCount(greenArrowSelect.name).ToString();
            purpleArrow.text = quiver.GetArrowCount(purpleArrowSelect.name).ToString();
        }

        public List<String> GetArrowTypes()
        {
            return ArrowTypes;
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

