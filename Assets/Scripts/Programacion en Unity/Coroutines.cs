using System.Collections;
using UnityEngine;

namespace Cours
{
    public class Coroutines : MonoBehaviour
    {
        private void Start()
        {
            #region Start
            StartCoroutine(CallCoroutine());

            StartCoroutine("CallCoroutine");

            Coroutine myCoroutine;
            myCoroutine = StartCoroutine(CallCoroutine());
            #endregion

            #region Stop
            StopCoroutine(CallCoroutine());
            StopCoroutine("CallCoroutine");
            StopCoroutine(myCoroutine);
            StopAllCoroutines();
            #endregion

            #region Parameters

            StartCoroutine(CallCoroutineWithParams(2.5f, 100, "Test"));

            Coroutine myNewCoroutine;
            myNewCoroutine = StartCoroutine(CallCoroutineWithParams(2.5f, 100, "Test"));

            #endregion
        }

        private IEnumerator CallCoroutine()
        {
            Debug.Log("Call");

            yield return new WaitForSeconds(5f);

            Debug.Log("Call 2");
        }

        private IEnumerator CallCoroutineWithParams(float myFloat, int myInt, string myString)
        {
            yield return null;
        }
    }
}
