using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours.ShootGame
{
    public enum typeWeapon
    {
        None,
        fire,
        storm
    }
    [CreateAssetMenu(fileName = "New Weapon", menuName = "ScriptableObject/Weapon", order = 0)]
    public class WeaponSO : ScriptableObject
    {
        public Sprite sprite;
        public string weaponName;
        public float ammo;
        public float price;
        public typeWeapon type;

        public string GetPrice()
        {
            return string.Format("Price: {0}", price);
        }

        public string GetAmmo()
        {
            return string.Format("Ammo: {0}", ammo);
        }

        public string GetTypeWeapon()
        {

            return string.Format("Type: {0}", type);
        }
    }
}
