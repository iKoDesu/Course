using System.Globalization;
using UnityEngine;

namespace Cours.Enemy
{
    [CreateAssetMenu(fileName = "New Enemy", menuName = "ScriptableObject/Enemy", order = 0)]
    public class EnemySO : ScriptableObject
    {

        [Header("Enemy")]
        public string enemyName;
        public EnumsEnemies.TypeEnemy type;
        public EnumsEnemies.TypeElement element;
        public EnumsEnemies.TypeElement debility;



        [Space(10)]
        [Header("Stats")]
        public float heal;
        public int damage;

        [Space(10)]
        [Header("Model")]
        public GameObject model;

        public string GetTypeEnemy()
        {
            return string.Format("Ennemy: {0}", type);
        }

        public string GetTypeElement()
        {
            return string.Format("Élément: {0}", element);
        }

        public string GetTypeDebility()
        {
            return string.Format("Débilité: {0}", debility);
        }

        public string GetHeal()
        {
            return string.Format("Guérir: {0}", heal);
        }

        public string GetDamage()
        {
            return string.Format("Dommage: {0}", damage);
        }
    }
}
