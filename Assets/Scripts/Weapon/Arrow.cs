using System;
using System.Collections.Generic;
using Platformer.Mechanics;
using UnityEngine;

namespace Weapon
{
    public class Arrow : MonoBehaviour
    {
        private String ArrowType;
        [SerializeField] private ArrowSelector _arrowSelector;
        private string CurrentArrowType;

        public void Update()
        {
            SetArrowType();
        }
        
        public void SetArrowType()
        {
            CurrentArrowType = _arrowSelector.GetCurrentArrow();
        }
        public string GetArrowType()
        {
            return ArrowType;
        }
        
    }
}