using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Cours.EstructurasDeControl
{
    public class IfElse : MonoBehaviour
    {
        public bool canAttack;

        private void Attack()
        {
            //  If / Else
            if (canAttack)
            {
                Debug.Log("Attack!");

            }
            else
            {
                Debug.Log("I can't Attack.");
            }

            //  Operador ternario
            Debug.Log(canAttack ? "Attack!" : "I can't Attack.");

            //  Operador ternario
            int id = canAttack ? 24 : -1;

            if (canAttack)
                Debug.Log("Attack!");

            if (canAttack) Debug.Log("Attack!");
        }

        public int currentAmmo;
        public int totalAmmo;

        private void CheckAmmo()
        {
            if(currentAmmo > 0)
            {
                // Shoot
            }

            if(totalAmmo == 0 || currentAmmo <= 0)
            {
                // Requiere ammo
            }
        }

        public SphereCollider shieldCollider;

        private void Defense()
        {
            //  Code Smells (Es una mala practica)
            if(shieldCollider != null)
            {
                // Use shield
            }

            if (shieldCollider)
            {
                // Use shield
            }
        }
    }
}
