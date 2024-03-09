using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours.POO
{
    public abstract class Enemy : MonoBehaviour
    {
        [Header("Enemy")]
        [SerializeField] protected int damage;
        [SerializeField] protected float health;

        [SerializeField] private string _title;
        public string Title
        {
            get
            {
                //Debug.Log("Title GET");
                return _title;
            }
            //set
            //{
            //    Debug.Log("Title SET");
            //    _title = value;
            //}
        }

        private void Start()
        {
            //Attack();

            ////  Get
            //string temp = Title;

            ////  Set
            //Title = "Pepe";
        }

        public virtual void Attack()
        {
            Debug.Log($"Enemy '{_title}' ATTACK. Damage: '{damage}'");
        }

        public abstract void Defense();
    }
}
