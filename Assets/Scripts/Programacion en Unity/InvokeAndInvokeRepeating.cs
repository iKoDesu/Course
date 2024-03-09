using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours
{
    public class InvokeAndInvokeRepeating : MonoBehaviour
    {
        private void Start()
        {
            //Invoke("CallInvoke", 3f);
            InvokeRepeating("CallInvoke", 3f, 1f);
            CancelInvoke();
            IsInvoking("CallInvoke");
        }

        void CallInvoke()
        {
            Debug.Log("Invoke Call");
        }
    }
}
