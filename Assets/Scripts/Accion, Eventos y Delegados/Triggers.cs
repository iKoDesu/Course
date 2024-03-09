using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Cours
{
    public class Triggers : MonoBehaviour
    {
        public UnityEvent unityEventEnter;
        public UnityEvent unityEventStay;
        public UnityEvent unityEventExit;

        public float SetMaxTime = 3;
        public float maxtime { get { return SetMaxTime; } }
        public float timeWait;

        private void Start()
        {
            timeWait = maxtime;
        }
        private void OnTriggerEnter(Collider other)
        {
            unityEventEnter.Invoke();
        }

        private void OnTriggerStay(Collider other)
        {
            timeWait -= Time.deltaTime;

            if (timeWait <= 0)
            {
                unityEventStay.Invoke();
                timeWait = maxtime;
            }
            else Debug.Log("Esperando");
        }

        private void OnTriggerExit(Collider other)
        {
            unityEventExit.Invoke();
        }

        public void PrintMessage(string text)
        {
            Debug.Log(text);
        }
    }
}
