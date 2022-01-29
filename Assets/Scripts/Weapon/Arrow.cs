using Platformer.Mechanics;
using UnityEngine;

namespace Weapon
{
    public class Arrow : MonoBehaviour

    {
        [SerializeField] private string color;

        [SerializeField] private GameObject player;
        public PlayerController playerController;
        private Vector2 _position;

        public void Start()
        {
            Transform playerTransform = player.transform;
            _position = playerTransform.position;
            transform.position = new Vector2(_position.x, _position.y);
            playerController = player.GetComponent<PlayerController>();
        }
        
        public string GetColor()
        {
            return color;
        }
    }
}