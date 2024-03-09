using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours.Atributos
{
    public class SerializeFieldHideInspector : MonoBehaviour
    {
        [SerializeField]
        private bool canShoot;

        [HideInInspector]
        public bool canRun;
    }
}
