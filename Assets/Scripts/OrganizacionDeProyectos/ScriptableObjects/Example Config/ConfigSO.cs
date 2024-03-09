using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours.OrganizacionProyecto
{
    [CreateAssetMenu(fileName = "New Config", menuName = "ScriptableObjects/Config", order = 1)]
    public class ConfigSO : ScriptableObject
    {
        [Header("General")]
        public int maxPlayers = 4;
        public float maxSpeedMovement = 1.2f;

        [Header("Animation")]
        public float fadeIntTime = 1.5f;
        public float fadeOutTime = 3f;
    }
}
