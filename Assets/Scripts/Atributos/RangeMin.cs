using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours.Atributos
{
    public class RangeMin : MonoBehaviour
    {
        [Range(1f, 100f)]
        public float shootSpeed;

        [Range(1, 10)]
        public int shootRate;

        [Min(2.5f)]
        public float bulletsSpeed;

        [Min(1)]
        public int bulletsPerShoot;
    }
}
