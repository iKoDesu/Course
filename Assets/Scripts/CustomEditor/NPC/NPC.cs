using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cours.Citizen
{
    public class NPC : MonoBehaviour
    {
        public NPCSO data;

        [Space]

        public Image npcImage;
        public TextMeshProUGUI npcNameTxt;
        public TextMeshProUGUI npctypeTxt;
        public TextMeshProUGUI npcHealTxt;
        public void Consume()
        {
            npcImage.sprite = data.sprite;
            npcNameTxt.text = data.name;
            npctypeTxt.text = data.GetTypeCityzen();
            npcHealTxt.text = data.GetHeal();
        }
    }
}
