using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Cours.AccionesEventosDelegados
{
    public class Events : MonoBehaviour
    {
        //  Event
        //  Exclusivo de C#
        //  Para trabajarlo
        public delegate void MyDelegateEvent();

        //public MyDelegateEvent myDelegateEventVar;  // Delegate
        //  Para ejecutar el delegate como un evento
        public event MyDelegateEvent myEventVar;  // Evento

        //  UnityEvents
        //  Diseñado para unity. Funcionan igual pero se pueden asignar desde el editor.
        //  Permite añadir un comportamiento adicional para ejecutar cuando se llame al evento.
        public UnityEvent myUnityEventVar;

        //  Tambien funciona con variables
        //  Estas tambien pueden ser mediante parametros de otros componentes, como si un objeto esta activo, etc.
        //  Desde unity si un componente cumple con todos los requisitos el UnityEvent este saldr acomo Dynamic.
        public UnityEvent<bool> myUnityEventOneParamsVar;
        public UnityEvent<bool, int, string> myUnityEventThreeParamsVar;

        private void Start()
        {
            //  Event
            //  Para asignarlo
            myEventVar += PrintMassage;

            myEventVar -= PrintMassage;

            //  Para ejecutarlo
            //myEventVar();
            //myEventVar.Invoke();

            //  UnityEvents
            //  Para asignarlo
            myUnityEventVar.AddListener(PrintMassage); // +=
            myUnityEventVar.RemoveListener(PrintMassage); // -=

            myUnityEventVar.Invoke();

            myUnityEventOneParamsVar.Invoke(true);
            myUnityEventThreeParamsVar.Invoke(true, 10, "Hello");
        }
        private void PrintMassage()
        {
            Debug.Log("Hello World!");
        }
    }
}
