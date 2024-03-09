using UnityEngine;

namespace Cours.Citizen
{
    public enum TypeCitizen
    {
        None,
        calme,
        angry,
        dynamic,
        pacific
    }

    [CreateAssetMenu(fileName = "New NPC", menuName = "ScriptableObject/Citizen/NPC", order =0)]
    public class NPCSO : ScriptableObject
    {
        public Sprite sprite;
        public string npcName;
        public TypeCitizen typeCitizen;
        public float heal;

        public string GetHeal()
        {
            return string.Format("Health: {0}", heal);
        }

        public string GetTypeCityzen()
        {
            return string.Format("Type: {0}", typeCitizen);
        }
    }
}
