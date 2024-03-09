using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Concurrent;

namespace Cours.ShootGame
{
    public class Weapon : MonoBehaviour
    {
        public WeaponSO data;

        [Space]

        public Image weaponImage;
        public TextMeshProUGUI weaponNameTxt;
        public TextMeshProUGUI ammoTxt;
        public TextMeshProUGUI typeTxt;
        public TextMeshProUGUI priceTxt;

        public void Consume()
        {
            weaponImage.sprite = data.sprite;
            weaponNameTxt.text = data.name;
            ammoTxt.text = data.GetAmmo();
            typeTxt.text = data.GetTypeWeapon();
            priceTxt.text = data.GetPrice();
        }
    }
}
