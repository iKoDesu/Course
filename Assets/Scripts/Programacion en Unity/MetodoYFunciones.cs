using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours
{
    public class MetodoYFunciones : MonoBehaviour
    {
        private void Start()
        {
            Shoot(typeDamage: 2);

            int myId;
            string myName;

            //Toda directamente el valor y se lo retorna.
            ChangePlayerIdWithOut(out myId, out myName);
            ChangePlayerIdWithRef(ref myId);
        }

        public void Shoot(int damage = 5, int typeDamage = 3)
        {

        }

        private int GetPlayerID()
        {
            return 10;
        }

        private void ChangePlayerIdWithOut(out int id, out string name)
        {
            id = 10;
            name = "Jose";
        }

        private void ChangePlayerIdWithRef(ref int id)
        {
            id = 10;
        }
    }
}
