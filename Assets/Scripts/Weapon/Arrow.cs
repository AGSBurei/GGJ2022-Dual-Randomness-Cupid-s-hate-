using System;
using System.Collections.Generic;
using Platformer.Mechanics;
using UnityEngine;

namespace Weapon
{
    public class Arrow : MonoBehaviour
    {
        public void Update()
        {
            transform.Translate((transform.forward * 20 * Time.deltaTime));
        }
    }
}