using System;
using UnityEngine;

namespace Weapon
{
    
    public class Bow : MonoBehaviour

    {
        [SerializeField]
        private Quiver quiver;
        [SerializeField]
        private Arrow _arrow;
        private string _currentArrowType;
        
        public void Awake()
        {
        }

        public void Update()
        {
            _currentArrowType = _arrow.GetArrowType();
            if (Input.GetMouseButtonDown(0) && quiver.GetArrowCount((_currentArrowType)) > 0)
            {
                Shoot(_currentArrowType);
            }
        }

       
        public void RemoveArrowFromQuiver(string arrowType)
        {
            quiver.UpdateArrow(arrowType);
        }
        public void Shoot(String currentArrow)
        {
            RemoveArrowFromQuiver(currentArrow);
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log(hit.collider.name);
            }
        }
    }
}