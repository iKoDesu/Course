using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours
{
    public class Conversion : MonoBehaviour
    {
        private void Start()
        {
            // Conversión (Cast)
            int myCastInt = (int)2.55f;
            Debug.Log(myCastInt);

            Collider myCollider = GetComponent<Collider>();
            BoxCollider myBoxCollider;

            myBoxCollider = (BoxCollider)myCollider;
            myBoxCollider = myCollider as BoxCollider;

            // Conversión (Parse)
            string myStringInt = "128";
            int myIntParsed;
            //  Metodo 1
            myIntParsed = int.Parse(myStringInt);
            //  Metodo 2
            bool resultParse = int.TryParse(myStringInt, out myIntParsed);

            // Conversión (Enum)
            string myStringEnum = "Fire";

            AttackType myEnum;
            myEnum = (AttackType)System.Enum.Parse(typeof(AttackType), myStringEnum);
        }
    }
}
