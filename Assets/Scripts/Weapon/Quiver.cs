using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Weapon
{ 
    public class Quiver : MonoBehaviour

    {
        [SerializeField] public int minArrow;
        [SerializeField] public int maxArrow;
        [SerializeField] public ArrowSelector arrowSelector;
        private Dictionary<string, int> _Arrow = new Dictionary<string, int>();

        public void Awake()
        {
            InitializedArrow();
        }

        private void InitializedArrow()
        {
            foreach (var arrowType in arrowSelector.GetArrowTypes())
            {
                if (arrowType != null)
                {
                    _Arrow.Add(arrowType, Random.Range(minArrow, maxArrow));
                }
            }
        }

        public int GetArrowCount(string arrowType)
        { 
            var arrowCount = 0;
            foreach (KeyValuePair<string, int> arrow in _Arrow)
            {
                if (arrow.Key == arrowType)
                {
                    arrowCount = arrow.Value;
                }
            }
            
            return arrowCount;
        }
        
        public void SetArrowCount(string arrowType)
        {
            var arrowCount = 0;
            var tempArrow = new List<string>();
            
            foreach (var arrow in _Arrow)
            {
                if (arrow.Key == arrowType)
                {
                    tempArrow.Add(arrow.Key);
                    arrowCount = arrow.Value - 1;
                }
            }

            foreach (var key in tempArrow)
            {
                _Arrow[key] = arrowCount;
            }
        }
        public void UpdateArrow(string arrowType)
        {
            SetArrowCount(arrowType);
        }
    }
}