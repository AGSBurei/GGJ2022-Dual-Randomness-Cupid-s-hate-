using System;
using System.Collections.Generic;
using Platformer.Mechanics;
using UnityEngine;

namespace Weapon
{
    public class Arrow : MonoBehaviour
    {
        [SerializeField] private GameObject player;
        [SerializeField] public ArrowSeletor arrowSeletor;
        [SerializeField] public PlayerController playerController;
        private Vector2 _position;
        private String currentArrow;

        public void Start()
        {
            Transform playerTransform = player.transform;
            _position = playerTransform.position;
            transform.position = new Vector2(_position.x, _position.y);
            playerController = player.GetComponent<PlayerController>();
        }

        public void LateUpdate()
        {
            currentArrow = arrowSeletor.GetCurrentArrow();
        }

        public string GetArrow()
        {
            return currentArrow;
        }
        
        public List<String> GetArrowType()
        {
            return arrowSeletor.GetArrowType();
        }
    }
}