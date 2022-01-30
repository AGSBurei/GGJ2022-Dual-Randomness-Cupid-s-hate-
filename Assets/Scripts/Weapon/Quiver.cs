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
        private List<Dictionary<string, int>> _Arrow = new List<Dictionary<string, int>>();

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
                    var dico = new Dictionary<string, int>();
                    dico.Add(arrowType, Random.Range(minArrow, maxArrow));
                    _Arrow.Add(dico);
                }
            }
        }

        public int GetArrowCount(string arrowType)
        { 
            var arrowCount = 0;
            foreach (Dictionary<string, int> arrowList in _Arrow )
            {
                foreach (KeyValuePair<string, int> arrow in arrowList)
                {
                    if (arrow.Key == arrowType)
                    {
                        arrowCount = arrow.Value;
                    }
                }
            }
            return arrowCount;
        }
        
        public void SetArrowCount(string arrowType)
        {
            var arrowCount = 0;
            var tempArrow = new List<string>();
            
            
            foreach (var dictionary in _Arrow.ToList())
            {
                if (dictionary != null)
                {
                    foreach (var arrow in dictionary)
                    {
                        if (arrow.Key == arrowType)
                        {
                            tempArrow.Add(arrow.Key);
                            arrowCount = arrow.Value - 1;
                        }
                    }
                }
            }


            //foreach (var dictionary in _Arrow.ToList())
            //{
            //    if (dictionary != null)
            //    {
            //        foreach (var arrow in dictionary)
            //        {
            //            if (arrow.Key == arrowType)
            //            {
            //                tempArrow.Add(arrow.Key);
            //                arrowCount = arrow.Value - 1;
            //            }
            //        }
            //    }
            //}
            //
            //

            //foreach (var key in tempArrow)
            //{
            //    //dictionary[arrow.Key] = arrowCount;
            //    
            //}
        }

        public void UpdateArrow(string arrowType)
        {
            SetArrowCount(arrowType);
        }
    }
}