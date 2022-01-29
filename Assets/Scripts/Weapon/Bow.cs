using System;
using UnityEngine;

namespace Object
{
    
    public class Bow : MonoBehaviour

    {
        [SerializeField]
        private Quiver quiver;

        private string _currentArrowType;

        public void Start()
        {
            
        }

        public void Awake()
        {
            throw new NotImplementedException();
        }

        public string GetArrowType()
        {
            return _currentArrowType;
        }
        public void SetCurrentArrowType(string arrowType)
        {
            _currentArrowType = arrowType;
        }
        public void Shoot()
        {
            
        }
    }
}