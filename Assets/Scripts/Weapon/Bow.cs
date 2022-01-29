using System;
using UnityEngine;

namespace Weapon
{
    
    public class Bow : MonoBehaviour

    {
        [SerializeField]
        private Quiver quiver;

        private string _currentArrowType;
        
        public void Awake()
        {
            
        }

        public void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

                if (hit.collider != null)
                {
                    Debug.Log(hit.collider.name);
                }
            }
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