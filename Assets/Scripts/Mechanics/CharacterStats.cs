using System;
using Platformer.Gameplay;
using UnityEngine;
using static Platformer.Core.Simulation;

namespace Platformer.Mechanics
{
    public class CharacterStats : MonoBehaviour
    {
        [SerializeField]
        public int HP;
        [SerializeField]
        public int STR;
        [SerializeField]
        public int AGI;
        
        int currentHP;
        
        public bool IsAlive => currentHP > 0;
        
        public void Increment()
        {
            currentHP = Mathf.Clamp(currentHP + 1, 0, HP);
        }
        
        public void Decrement()
        {
            currentHP = Mathf.Clamp(currentHP - 1, 0, HP);
            if (currentHP == 0)
            {
                var ev = Schedule<HealthIsZero>();
                ev.health = this;
            }
        }
        
        public void Die()
        {
            while (currentHP > 0) Decrement();
        }

        void Awake()
        {
            currentHP = HP;
        }
    }
}    