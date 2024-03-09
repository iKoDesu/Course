using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace Cours.Enemy
{
    public class Enemy : MonoBehaviour
    {
        [Header("Data")]
        public EnemySO data;

        [Space(10)]
        [Header("UI reference")]
        public TextMeshProUGUI nameEnemyTxt;
        public TextMeshProUGUI typeEnemyTxt;
        public TextMeshProUGUI typeElementTxt;
        public TextMeshProUGUI typeDebilityTxt;
        public TextMeshProUGUI healTxt;
        public TextMeshProUGUI damageTxt;

        [Space(10)]
        [Header("Model")]
        public GameObject model;

        public void Consume()
        {
            nameEnemyTxt.text = data.enemyName;
            typeEnemyTxt.text = data.GetTypeEnemy();
            typeElementTxt.text = data.GetTypeElement();
            typeDebilityTxt.text = data.GetTypeDebility();
            healTxt.text = data.GetHeal();
            damageTxt.text = data.GetDamage();
            
            if(model != null)
                DestroyImmediate(model);

            model = Instantiate(data.model, transform.position, transform.rotation);
        }
    }
}
