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

        public int currentHP = 5;

        public bool IsAlive => HP > 0;
        
        public void HPup(int hp)
        {
            HP = HP + hp;

            currentHP = currentHP + hp;
        }
        
        public void HPdown(int hp)
        {
            if ((HP - hp) >= 0)
            {
                HP = HP - hp;
            }
            
            if (HP == 0)
            {
                var ev = Schedule<HealthIsZero>();
                ev.health = this;
            }
        }
        
        public void Die()
        {
            while (HP > 0) HPdown(1);
        }
        
        public void STRup(int up)
        {
            STR = STR + up;
        }
        
        public void STRdown(int down)
        {
            if ((STR - down) >= 0)
            {
                STR = STR - down;
            }
        }
        
        public void AGIup(int up)
        {
            AGI = AGI + up;
        }
        
        public void AGIdown(int down)
        {
            if ((AGI - down) >= 0)
            {
                AGI = AGI - down;
            }
        }

        public void Awake()
        {
            currentHP = HP;
        }
    }
}    