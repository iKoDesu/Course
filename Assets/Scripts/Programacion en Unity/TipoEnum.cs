using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum AttackType
{
    None,
    Fire,
    Ice,
    Sword,
    Punch
}

namespace Cours
{
    public class TipoEnum : MonoBehaviour
    {

        public AttackType attackTypeEnum = AttackType.Sword;

        string myName = "Jose";
        int age = 26;

        private void Start()
        {
            string personaje = string.Format("Se llama {0} y tiene {1}", myName, age);
            personaje = $"Se llama {myName} y tiene {age} años";
        }
    }
}
