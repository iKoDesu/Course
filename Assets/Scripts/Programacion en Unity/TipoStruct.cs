using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours
{
    public class TipoStruct : MonoBehaviour
    {
        public string playerName;
        public int playerHealth;
        public bool playerIsDead;

        [System.Serializable]
        public struct PlayerData
        {
            public string name;
            public int health;
            public bool isDead;
            public int ammo;
        }

        public PlayerData playerData;

        private void Start()
        {
            playerData.name = "Jose";
            playerData.health = 100;
            playerData.isDead = false;
        }

        private void ChangeInfo(PlayerData data)
        {
            data.ammo = 0;
        }
    }
}
