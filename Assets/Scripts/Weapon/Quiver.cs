using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Weapon
{ 
    public class Quiver : MonoBehaviour

    {
        [SerializeField] public int minArrow;
        [SerializeField] public int maxArrow;
        [SerializeField] public Arrow arrow;
        private List<Dictionary<string, int>> _Arrow = new List<Dictionary<string, int>>();

        public void Awake()
        {
            InitializedArrow();
        }
        
        private void InitializedArrow()
        {
            foreach (var arrowType in arrow.GetArrowType())
            {
                if (arrowType != null)
                {
                    var dico = new Dictionary<string, int>();
                    dico.Add(arrowType, Random.Range(minArrow, maxArrow));
                    _Arrow.Add(dico);
                }
            }
            Debug.Log(_Arrow);
        }

    }
}