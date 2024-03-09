using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours.POO
{
    public class EnemyOrc : Enemy
    {
        public override void Attack()
        {
            damage = 999;
            //  Base llama a la linea de codigo que tiene su padre.
            base.Attack();

            Debug.Log($"I'm an Orc!");
        }

        public override void Defense()
        {
            
            Debug.Log($"Enemy '{Title}' DEFENSE. Health '{health}'");
        }
    }
}
