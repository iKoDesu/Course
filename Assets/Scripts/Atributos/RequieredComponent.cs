using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours.Atributos
{
    [RequireComponent(typeof(HeaderSpace), typeof(Rigidbody))]
    public class RequieredComponent : MonoBehaviour
    {
        private BoxCollider boxCollider;
        private Rigidbody rigidbody;

        private void Awake()
        {
            boxCollider = GetComponent<BoxCollider>();
            rigidbody = GetComponent<Rigidbody>();
        }

        private void Start()
        {
            boxCollider.enabled = true;
            rigidbody.isKinematic = true;
        }
    }
}
