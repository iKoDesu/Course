using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours
{
    public class VisibleAndInvisible : MonoBehaviour
    {
        private void OnBecameVisible()
        {
            Debug.Log("Visible");
        }

        private void OnBecameInvisible()
        {
            Debug.Log("Invisible");
        }
    }
}
