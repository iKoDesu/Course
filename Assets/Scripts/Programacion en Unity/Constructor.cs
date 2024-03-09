using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours
{
    public class Constructor : MonoBehaviour
    {
        private void Start()
        {
            Weapon myWeapon = new Weapon(100);

            myWeapon.Shoot();
        }
    }

    public class Weapon
    {
        int ammo;
        
        public Weapon()
        {
            ammo = 30;
        }

        public Weapon(int ammo)
        {
            this.ammo = ammo;
        }

        public void Shoot()
        {
            this.ammo -= 1;
        }

        public void Shoot(int ammo)
        {
            this.ammo -= ammo;
        }
    }
}
