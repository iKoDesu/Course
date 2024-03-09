using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours.EstructurasDeControl
{
    public enum EPlatform
    {
        None,
        PC,
        Xbox,
        Playstation,
        Switch
    }
    public class Switcher : MonoBehaviour
    {
        public int weaponType;
        public string enemyClass;
        public EPlatform currentPlatform;

        private void Start()
        {
            #region Int
            //  Para numeros enteros
            if (weaponType == 0)
            {
                // Do Something
            }
            else if (weaponType == 1)
            {
                // Do Something
            }
            else if(weaponType == 2)
            {
                // Do Something
            }
            else
            {
                // Do Something
            }

            switch (weaponType)
            {
                case 0:
                    // Do Something
                    break;
                case 1:
                case 8:
                case 15:
                    // Do Something
                    break;
                default:
                    // Do Something
                    break;
            }

            #endregion

            #region String
            switch (enemyClass)
            {
                case "Archer":
                    break;
                case "Warrior":
                    break;
                default: 
                    break;
            }
            #endregion

            #region Enum

            switch (currentPlatform)
            {
                case EPlatform.None:
                    break;
                case EPlatform.PC:
                    break;
                case EPlatform.Xbox:
                    break;
                case EPlatform.Playstation:
                    break;
                case EPlatform.Switch:
                    break;
                default:
                    break;
            }

            #endregion
        }
    }
}
