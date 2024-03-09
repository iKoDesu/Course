using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours.EstructurasDeControl
{
    public class ForEachWhile : MonoBehaviour
    {
        public int[] weaponAmmoArray;

        private void CheackWeaponAmmo()
        {
            // Variable temporal // Comparativa // Sucesion
            for (int i = 0; i < weaponAmmoArray.Length; i++)
            {
                Debug.Log($"Index {i} - Ammo: {weaponAmmoArray[i]}");
            }
            //  Tiene mas posibilidades ya que se puede acceder al indice

            // Crea variable temporal // Lugar donde quiero recorrer
            foreach (int weaponAmmo in weaponAmmoArray)
            {
                Debug.Log($"Index ? - Ammo: {weaponAmmo}");
            }
            //  Este no cuenta un indice de donde sacar valores con el en caso anterior.
            //  Sirve para recorrer y ejecutar cosas rapidamente

            
        }

        private IEnumerator Fade()
        {
            //  Uso clasico con Fade (De negro a transparente o transparente a negro)

            //Mientras una condición se cumpla se ejecuta.
            float alpha = 1.0f;
            while (alpha > 0)
            {
                alpha -= Time.deltaTime;
                yield return null;
            }
            //  Do something

        }
    }
}
